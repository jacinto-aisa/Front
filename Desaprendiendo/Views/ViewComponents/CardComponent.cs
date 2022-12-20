using System.Threading.Tasks;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.ContentItem;
using Microsoft.AspNetCore.Mvc;

namespace Desaprendiendo.Views.ViewComponents
{
    public class CardComponent : BaseComponent<ContentItem>
    {
        private readonly ILListContentFactory miFabrica;

        public CardComponent(ICategoriaRepository categoriaRepository,
            ISubCategoriaRepository subCategoriaRepository,
            ICursoRepository cursoRepository,
            IModuloRepository moduloRepository,
            ILeccionRepository leccionRepository) :
            base()

        {
            miFabrica = new ListContentFactory(categoriaRepository, subCategoriaRepository, cursoRepository,
                moduloRepository, leccionRepository);
            base.MyFactory = miFabrica;
        }

    }
}
