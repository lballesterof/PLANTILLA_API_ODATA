using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services.Persona;
using System.Linq;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpePersonaController : ControllerBase
    {

        // GET: api/<OpeProductoController>
        private readonly IOpePersonaServices _services;

        public OpePersonaController(IOpePersonaServices _services) =>
            this._services = _services;




        // GET: api/OpeTablas
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpePersona>> GetAllStudents()
        {
            IQueryable<OpePersona> retrievedProducts =
                (IQueryable<OpePersona>)this._services.RetrieveAllProductos();

            return Ok(retrievedProducts);
        }




    }
}
