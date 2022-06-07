using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.Beans.Productos;
using PLANTILLA_API_ODATA.Models.DTO.Productos;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Productos
{
    public interface IOpeProductoServices
    {
        IQueryable<OpeProducto> RetrieveAllProductos();

    }
}
