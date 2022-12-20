using System.Threading.Tasks;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.Menu;
using Microsoft.AspNetCore.Mvc;

namespace Desaprendiendo.Views.ViewComponents
{
    public class MenuComponent : ViewComponent
    {
 

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listaContenidos = new ListMenuFactory().GetAll();
            return await Task.Run(() => View(listaContenidos));
        }

    }
}
