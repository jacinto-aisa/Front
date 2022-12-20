using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.Views
{
    public interface IViewBagUtils
    {
        void PonValores(string categoria, int idCategoria, string subCategoria, int idSubCategoria);
    }
}
