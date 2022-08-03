using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using PLANTILLA_API_ODATA.Services.Usuario;
using System.Linq;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IOpeUsuarioService opeUsuarioService;
        public UsersController(IOpeUsuarioService opeUsuarioService) =>
        this.opeUsuarioService = opeUsuarioService;
        private string ipAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeUsuario>> GetAllUsers()
        {
            IQueryable<OpeUsuario> retrieveAllUsers =
                this.opeUsuarioService.RetrieveAllUsers();

            return Ok(retrieveAllUsers);
        }

        [HttpPost("Login")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest model)
        {
            AuthenticateResponse response = opeUsuarioService.Authenticate(model, ipAddress());

            if (response==null)
            {
                return BadRequest(new { message = "Usuario o Contraseña Incorrecta" });
            }
            else
            {
                return Ok(response);

            }

            //setTokenCookie(response.RefreshToken);

        }
        [HttpPost("LoginComercial")]
        public IActionResult AuthenticateComercial([FromBody] AuthenticateRequest model)
        {
            AuthenticateResponse response = opeUsuarioService.AuthenticateComercial(model, ipAddress());

            if (response == null)
            {
                return BadRequest(new { message = "Usuario o Contraseña Incorrecta" });
            }
            else
            {
                return Ok(response);

            }

            //setTokenCookie(response.RefreshToken);

        }



        [HttpPost("LoginClienteCuota")]
        public IActionResult AuthenticateClienteCuota([FromBody] AuthenticateClienteCuotaRequest model)
        {
            AuthenticateResponse response = opeUsuarioService.AuthenticateClienteCuotas(model, ipAddress());

            if (response == null)
            {
                return BadRequest(new { message = "Usuario o Contraseña Incorrecta" });
            }
            else
            {
                return Ok(response);

            }

            //setTokenCookie(response.RefreshToken);

        }
    }
}
