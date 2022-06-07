using PLANTILLA_API_ODATA.Models;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Mesas
{
    public interface IOpeMesaService
    {
        IQueryable<OpeMesa> RetrieveAllMesas();
   
    }
}
