using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Controllers
{
    public class SubCategoriasFrontController : Controller
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;
        private readonly IGenericPhotoRepository<SubCategoria> _genericPhotoRepository;

        public SubCategoriasFrontController(ISubCategoriaRepository subCategoriaRepository,
                                            IGenericPhotoRepository<SubCategoria> genericPhotoRepository)
        {
            this._subCategoriaRepository = subCategoriaRepository;
            this._genericPhotoRepository = genericPhotoRepository;
        }

        public async Task<IActionResult> Index(int id)
        {
            return View(await _subCategoriaRepository.GetAll().Where(p => p.Categoria == id).ToListAsync());
        }
        [ResponseCache(Duration = 3600, VaryByHeader = "Id")]
        public FileContentResult GetImgMiniatura(int id)
        {
            return _genericPhotoRepository.GetImg<Categoria>(id, Sizes.pequeño);
        }
        [ResponseCache(Duration = 3600, VaryByHeader = "Id")]
        public FileContentResult GetImgGrande(int id)
        {
            return _genericPhotoRepository.GetImg<Categoria>(id, Sizes.grande);
        }
    }
}