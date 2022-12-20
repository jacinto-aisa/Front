using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.ContentItem;
using Desaprendiendo.Views.ViewComponents.ViewModels.ModuloComp;

namespace Desaprendiendo.Views.ViewComponents
{
    public class ModulosComponent : BaseComponent <ModuloComp>
    {

        private readonly IListModuloCompFactory miFabrica;
        public ModulosComponent(ICategoriaRepository categoriaRepository,
                                          ISubCategoriaRepository subCategoriaRepository,
                                          ICursoRepository cursoRepository,
                                          IModuloRepository moduloRepository,
                                          ILeccionRepository leccionRepository) :
                                    base()
        {
            miFabrica = new ListModuloCompFactory(categoriaRepository,subCategoriaRepository
                                                 ,cursoRepository, moduloRepository, leccionRepository);
            MyFactory = miFabrica;
        }
    }
}

