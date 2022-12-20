using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.Base;
using System.Collections.Generic;
using System.Linq;
using Desaprendiendo.Views.ViewComponents.ViewModels.Menu;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.Menu
{
    public class ListMenuFactory 
    {
        public List<Menu> GetAll()
        {
            var _elementosDeMenu = new List<Menu>()
            {
                new Menu()
                {
                    Titulo = "Cursos",
                    Controlador = "CategoriaFront",
                    Accion = "Index"
                },
                new Menu()
                {
                    Titulo = "Tripartita",
                    Controlador = "CategoriaFront",
                    Accion = "Tripartita"
                },
                new Menu()
                {
                    Titulo = "Metodología",
                    Controlador = "CategoriaFront",
                    Accion = "Metodologia"
                },
                new Menu()
                {
                    Titulo = "Nosotros",
                    Controlador = "CategoriaFront",
                    Accion = "Nosotros"
                }

            };

            return _elementosDeMenu;
        }
    }
}
