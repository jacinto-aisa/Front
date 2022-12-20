using Desaprendiendo.Models.Validation.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Desaprendiendo.Services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class

    {
        private readonly DBContextEF _dbContext;

        public GenericRepository(DBContextEF dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById(int id) => _dbContext.Set<T>().Find(id);

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).ToList();
        }

        public IEnumerable<T> SpecificationFilter(ISpecification<T> specification)
        {
            return _dbContext.Set<T>().Where(specification.IsSatisifiedBy());
        }

    }
}
