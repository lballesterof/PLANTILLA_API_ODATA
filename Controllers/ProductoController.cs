using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Productos;
using PLANTILLA_API_ODATA.Services;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using PLANTILLA_API_ODATA.Services.Productos;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        // GET: api/<OpeProductoController>
        private readonly IOpeProductoServices opeProductoServices;
        private readonly IConfiguration Configuration;

        public ProductoController(IOpeProductoServices opeProductoServices, IConfiguration _configuration)
        {
            this.opeProductoServices = opeProductoServices;
            Configuration = _configuration;

        }


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


        [HttpGet("/{nombrecategoria},{moneda}")]
        public async Task<IActionResult> getproductocategoriacomanda(string nombrecategoria, string moneda)
        {
            IEnumerable<ProductonombrecategoriaDTO> listproductcateory = null;
            IDbConnection db;
            using ( db = new SqlConnection(Global.ConnectionStrings)) 
            {
                if (db.State.Equals(ConnectionState.Closed))
                    {
                    db.Open();
                }

                DynamicParameters dynamicParameters1 = new DynamicParameters();
                dynamicParameters1.Add("@CDG_CATEGORIA", nombrecategoria);
                dynamicParameters1.Add("@TIPO_CLIENTE", "LPR0000001");
                dynamicParameters1.Add("@MONEDA", moneda);
                string str = "OPESS_OBTENER_PRODUCTO_NOMBRECATEGORIA";
                IDbConnection cnn = db;
                string sql = str;
                DynamicParameters dynamicParameters2 = dynamicParameters1;
                CommandType? nullable = new CommandType?(CommandType.StoredProcedure);
                int? commandTimeout = new int?();
                CommandType? commandType = nullable;
                listproductcateory = await cnn.QueryAsync<ProductonombrecategoriaDTO>(sql, (object)dynamicParameters2, commandTimeout: commandTimeout, commandType: commandType);
            }
            db.Close();
            return (IActionResult)new JsonResult(listproductcateory);
        }


        #region GetProducts 

        //private string _connection = @"Data Source=DESKTOP-CKJNAHP;Initial Catalog=Test_Products;User ID=sa;Password=Qz0966lb";
        [HttpGet("Comercial/{cdg_lista}/{CDG_MONEDA}/{TIPO_CAMBIO}")]
        public IActionResult GetProducts(string cdg_lista, string CDG_MONEDA, string TIPO_CAMBIO)
        {
            IEnumerable<Productos> listado = null;
            using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed) db.Open();
                {

                    DynamicParameters cmd = new DynamicParameters();
                    cmd.Add("@CDG_LISTA", cdg_lista);
                    cmd.Add("@CDG_MONEDA", CDG_MONEDA);
                    cmd.Add("@TIPO_CAMBIO", TIPO_CAMBIO);
                    var procedure = "GetDataProductoVta";

                    listado = db.Query<Productos>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure);

                }
            }

            return new JsonResult(listado);

        }

        #endregion





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
