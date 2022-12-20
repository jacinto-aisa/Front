using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Services.Repository
{
    public class GenericRepository : GenericRepository<Curso> , ICursoRepository
    {
        public GenericRepository(DBContextEF dbContext)
            : base(dbContext)
        {
        }

    }
}
