using Desaprendiendo.Models.Interfaces;
using System.Collections.Generic;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.Base
{
    public interface IGenerycListFactory <T> where T : class
    {
        List<T> GetAll(IEntity entidad);
    }
}
