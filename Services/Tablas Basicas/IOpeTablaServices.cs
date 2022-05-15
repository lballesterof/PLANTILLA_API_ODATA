using PLANTILLA_API_ODATA.Models;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services
{
    public interface IOpeTablaServices
    {
        IQueryable<OpeTabla> RetrieveAllTablas();
    }
}
