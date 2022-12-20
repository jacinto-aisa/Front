using Desaprendiendo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Desaprendiendo.Views.ViewComponents.ViewModels.Base;

namespace Desaprendiendo.Views.ViewComponents
{
    public class BaseComponent <T>: ViewComponent where T : class
    {
        public IGenerycListFactory<T> MyFactory { get; set; }

        public async Task<IViewComponentResult> InvokeAsync (IEntity entidad) 
        {
            var listaContenidos = MyFactory.GetAll(entidad);
            return await Task.Run(() => View(listaContenidos));
        }

    }
}
