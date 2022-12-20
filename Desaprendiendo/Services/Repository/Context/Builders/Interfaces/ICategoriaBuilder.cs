using Desaprendiendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Services.Repository.Context.Builders.Interfaces
{
    public interface ICategoriaBuilder
    {
        Categoria GetInstance(ref int number);
    }
}
