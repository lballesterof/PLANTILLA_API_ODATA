using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services;
using PLANTILLA_API_ODATA.Services.Productos;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeProductoController : ControllerBase
    {
        // GET: api/<OpeProductoController>
        private readonly IOpePersonaServices opeProductoServices;

        public OpeProductoController(IOpePersonaServices opeProductoServices) =>
            this.opeProductoServices = opeProductoServices;




        // GET: api/OpeTablas
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeProducto>> GetAllStudents()
        {
            IQueryable<OpeProducto> retrievedProducts =
                this.opeProductoServices.RetrieveAllProductos();

            return Ok(retrievedProducts);
        }

        // GET api/<OpeProductoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OpeProductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OpeProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OpeProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
