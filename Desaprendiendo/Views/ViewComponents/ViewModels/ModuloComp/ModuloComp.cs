using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.ModuloComp
{
    public class ModuloComp 
    {
        public string TituloModulo { get; set; }
        public string DescripcionModulo { get; set; }
        public IEnumerable<Lección> LeccionesDelModulo { get; set; }
    }
}
