using Ardalis.Specification;

namespace PLANTILLA_API_ODATA.Interfaces
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }
    public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {

    }
}
