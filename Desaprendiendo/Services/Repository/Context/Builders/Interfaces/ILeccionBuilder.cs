using Desaprendiendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Services.Repository.Context.Builders.Interfaces
{
    public interface ILeccionBuilder
    {
        Lección GetInstance(ref int number);
    }
}
