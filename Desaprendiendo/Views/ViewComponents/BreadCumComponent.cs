using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.BreadCum;

namespace Desaprendiendo.Views.ViewComponents
{

    //ViewComponent que muestra el breadcum para Subcategorias, Cursos y Modulos
    public class BreadCumComponent : BaseComponent<Bread>
    {

        private readonly ILListBreadFactory miFabrica;
        public BreadCumComponent (ICategoriaRepository categoriaRepository,
                                  ISubCategoriaRepository subCategoriaRepository,
                                  ICursoRepository cursoRepository,
                                  IModuloRepository moduloRepository,
                                  ILeccionRepository leccionRepository):
                            base()
        {
           miFabrica = new ListBreadFactory(categoriaRepository, subCategoriaRepository, cursoRepository, moduloRepository, leccionRepository);
           MyFactory =  miFabrica;
        }
    }
}
