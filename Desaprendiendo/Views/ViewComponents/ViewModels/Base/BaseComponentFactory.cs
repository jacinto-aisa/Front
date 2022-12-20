using Desaprendiendo.Services.Repository;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.Base
{

    public class BaseComponentFactory
    {
        protected ICategoriaRepository _categoriaRepository;
        protected ISubCategoriaRepository _subCategoriaRepository;
        protected ICursoRepository _cursoRepository;
        protected IModuloRepository _moduloRepository;
        protected ILeccionRepository _leccionRepository;
        public BaseComponentFactory(ICategoriaRepository categoriaRepository, ISubCategoriaRepository subCategoriaRepository, ICursoRepository cursoRepository, IModuloRepository moduloRepository, ILeccionRepository leccionRepository)
        {
            _categoriaRepository = categoriaRepository;
            _subCategoriaRepository = subCategoriaRepository;
            _moduloRepository = moduloRepository;
            _cursoRepository = cursoRepository;
            _leccionRepository = leccionRepository;
        }
    }
}
