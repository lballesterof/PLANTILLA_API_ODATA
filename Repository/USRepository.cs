using Ardalis.Specification.EntityFrameworkCore;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Interfaces;

namespace PLANTILLA_API_ODATA.Repository
{
    public class USRepository<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly DataContext dbContext;

        public USRepository(DataContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
