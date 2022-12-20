using Desaprendiendo.Models;
using Desaprendiendo.Services.Mail;
using Desaprendiendo.Services.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Controllers
{
    public class CursosFrontController : Controller
    {
        private int _idCurso;
        private readonly ICursoRepository _repositorioCursos;
        public ISubCategoriaRepository RepositorioSubCategoria { get; }
        public IGenericPhotoRepository<Curso> RepositorioFotos { get; }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public IEMail EmailSender { get; }

        public CursosFrontController(ICursoRepository repositorioCursos, ISubCategoriaRepository repositorioSubCategoria,
                                     IGenericPhotoRepository<Curso> repositorioFotos,IWebHostEnvironment webHostEnvironment,
                                     IEMail emailSender)
        {
            _repositorioCursos = repositorioCursos;
            RepositorioSubCategoria = repositorioSubCategoria;
            RepositorioFotos = repositorioFotos;
            WebHostEnvironment = webHostEnvironment;
            EmailSender = emailSender;
        }

        public async Task<IActionResult> Index(int id)
        {
            return View(await _repositorioCursos.GetAll().Where(p => p.SubCategoria == id).ToListAsync());
        }
        [ResponseCache(Duration = 3600, VaryByHeader = "Id")]
        public FileContentResult GetImgMiniatura(int id)
        {
            return RepositorioFotos.GetImg<Curso>(id,Sizes.pequeño);
        }
        [ResponseCache(Duration = 3600, VaryByHeader = "Id")]
        public FileContentResult GetImgGrande(int id)
        {
            return RepositorioFotos.GetImg<Curso>(id, Sizes.grande);
        }
        public async Task<IActionResult> Information(int id)
        {
            var _Curso = _repositorioCursos.GetById(id);
            _idCurso = _Curso.Id;
            MailConfiguration _configuracion = new MailConfiguration
            {
                Body = $"Quisiera más información sobre el curso: {_Curso.Curso1}"
            };
            return await Task.Run(() => View(_configuracion));
        }
        [HttpPost]
        public async Task <IActionResult> Information(MailConfiguration envio)
        {
            var cuerpo = $"El cliente con correo: {envio.CcEmail} /n ha realizado la siguiente consulta: {envio.Body}";
            await EmailSender.SendEmailAsync(cuerpo);
            return RedirectToAction("index", "ModulosFront", _idCurso);
        }
    }

}
