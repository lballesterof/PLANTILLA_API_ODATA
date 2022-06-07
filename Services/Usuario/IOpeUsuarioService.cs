using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Usuario
{
    public interface IOpeUsuarioService
    {
        IQueryable<OpeUsuario> RetrieveAllUsers();
    }
}
