using Desaprendiendo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.Repository.Context
{
    public interface IFakeRepositoryBuilder
    {
        IEntity Createinstance(Tipo tipo);
    }
}
