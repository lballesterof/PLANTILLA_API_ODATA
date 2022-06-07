using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.DetalleTabla;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services
{
    public interface IOpeTablaServices
    {
        IQueryable<OpeTabla> RetrieveAllTablas();
        IQueryable<OpeDetalleTabla> RetrieveAllDetailTablas();
    }
}
