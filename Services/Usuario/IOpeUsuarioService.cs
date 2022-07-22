using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Usuario
{
    public interface IOpeUsuarioService
    {
        IQueryable<OpeUsuario> RetrieveAllUsers();
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse AuthenticateComercial(AuthenticateRequest model, string ipAddress);
        //AuthenticateResponse RefreshToken(string token, string ipAddress);
        //bool RevokeToken(string token, string ipAddress);

        OpeUsuario finbyId(string id);
    }
}
