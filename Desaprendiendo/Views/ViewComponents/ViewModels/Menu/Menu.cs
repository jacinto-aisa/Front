using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.Interfaces;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.Menu
{
    public class Menu 
    {
        public string Titulo { get; set; }
        public string Controlador { get; set; }
        public string Accion { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
