using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Desaprendiendo.Services.Repository
{
    public enum Sizes
    {
        pequeño,
        grande
    };

    public interface IGenericRepository<T> where  T: class 
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);
    }
    
}
