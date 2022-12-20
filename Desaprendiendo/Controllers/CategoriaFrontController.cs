using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Desaprendiendo.Controllers
{
    public class CategoriaFrontController : Controller
    {

        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IGenericPhotoRepository<Categoria> _repositorioFotos;

        public CategoriaFrontController(ICategoriaRepository categoriaRepository, IGenericPhotoRepository<Categoria> repositorioFotos)
        {
            this._categoriaRepository = categoriaRepository;
            this._repositorioFotos = repositorioFotos;
        }

        // GET: CategoriaFront
        public async Task<IActionResult> Index()
        {
            return View(await _categoriaRepository.GetAll().ToArrayAsync());
        }

        public async Task<IActionResult> Tripartita()
        {
            return await Task.Run(() => View());
        }

        public async Task<IActionResult> Nosotros()
        {
            return await Task.Run(() => View());
        }
        public async Task<IActionResult> Metodologia()
        {
            return await Task.Run(() => View());
        }

        [ResponseCache(Duration = 3600,VaryByHeader ="Id")]
        public FileContentResult GetImgMiniatura(int id)
        {
            return _repositorioFotos.GetImg<Categoria>(id, Sizes.pequeño);
        }
        [ResponseCache(Duration = 3600, VaryByHeader = "Id")]
        public FileContentResult GetImgGrande(int id)
        {
            return _repositorioFotos.GetImg<Categoria>(id, Sizes.grande);
        }

        
    }
}