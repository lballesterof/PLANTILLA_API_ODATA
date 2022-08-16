using Ardalis.Specification.EntityFrameworkCore;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Interfaces;

namespace PLANTILLA_API_ODATA.Repository
{
    public class CuotaRepository<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly CuotasContext dbContext;

        public CuotaRepository(CuotasContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
