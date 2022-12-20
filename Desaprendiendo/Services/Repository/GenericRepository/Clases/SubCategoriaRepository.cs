using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Services.Repository
{
    public class SubCategoryRepository : GenericRepository<SubCategoria> , ISubCategoriaRepository
    {
        public SubCategoryRepository(DBContextEF dbContext)
            : base(dbContext)
        {
        }

    }
}
