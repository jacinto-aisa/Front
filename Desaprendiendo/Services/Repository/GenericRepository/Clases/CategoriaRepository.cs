using Desaprendiendo.Models;
using Desaprendiendo.Models.Validation.Interfaces;
using System.Linq;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Services.Repository
{
    public class CategoryRepository : GenericRepository<Categoria> , ICategoriaRepository
    {

        public CategoryRepository(DBContextEF dbContext)
            : base(dbContext)
        {
        }

        public new IQueryable<Categoria> GetAll()
        {
            return base.SpecificationFilter(new CategoriaImagenesSpecification()).AsQueryable();
            //return base.GetAll().Where(p => (p.ImagenMiniatura != null && p.ImagenGrande != null));
        }


    }
}
