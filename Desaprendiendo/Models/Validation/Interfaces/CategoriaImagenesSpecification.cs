using System;
using System.Linq.Expressions;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Models.Validation.Interfaces
{
    public class CategoriaImagenesSpecification : ISpecification<Categoria>
    {

        public Expression<Func<Categoria, bool>> IsSatisifiedBy()
        {
            return x => x.ImagenMiniatura != null && x.ImagenGrande != null;
        }
    }
}
