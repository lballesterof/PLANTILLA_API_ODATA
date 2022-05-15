using PLANTILLA_API_ODATA.Models;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Productos
{
    public interface IOpePersonaServices
    {
        IQueryable<OpeProducto> RetrieveAllProductos();
    }
}
