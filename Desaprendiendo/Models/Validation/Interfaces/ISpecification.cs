using System;
using System.Linq.Expressions;

namespace Desaprendiendo.Models.Validation.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> IsSatisifiedBy();
    }
}