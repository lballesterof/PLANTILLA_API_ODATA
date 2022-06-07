using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services.Mesas;
using System.Linq;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesasController : ControllerBase
    {

        private readonly IOpeMesaService _services;

        public MesasController(IOpeMesaService _services) => this._services = _services;

        // GET: api/OpeTablas
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeMesa>> GetAllStudents()
        {
            IQueryable<OpeMesa> retrievedProducts =
                (IQueryable<OpeMesa>)this._services.RetrieveAllMesas();

            return Ok(retrievedProducts);
        }



    }
}
