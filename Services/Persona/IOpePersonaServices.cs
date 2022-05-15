using PLANTILLA_API_ODATA.Models;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Persona
{
    public interface IOpePersonaServices
    {
        IQueryable<OpePersona> RetrieveAllProductos();
    }
}
