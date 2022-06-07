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


        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeUsuario>> GetAllUsers()
        {
            IQueryable<OpeUsuario> retrieveAllUsers =
                this.opeUsuarioService.RetrieveAllUsers();

            return Ok(retrieveAllUsers);
        }
    }
}
