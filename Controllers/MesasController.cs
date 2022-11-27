using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using PLANTILLA_API_ODATA.Services.Mesas;
using System;
using System.Data;
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

        [HttpPut("EstadoMesa/{Piso}/{Mesa}/{Estado}/{Mozo}")]
        public IActionResult UpdateEstado(string Piso, int Mesa, string Estado, string Mozo)
        {

                using (IDbConnection cnn = (IDbConnection)new SqlConnection(Global.ConnectionStrings))
                {
                    cnn.Open();
                    using (SqlTransaction sqlTransaction = (SqlTransaction)cnn.BeginTransaction())
                    {
                        try
                        {
                            DynamicParameters dynamicParameters1 = new DynamicParameters();
                            dynamicParameters1.Add("@PISO", (object)Piso);
                            dynamicParameters1.Add("@MESA", (object)Mesa);
                            dynamicParameters1.Add("@ESTADO", (object)Estado);
                            dynamicParameters1.Add("@MOZO", (object)Mozo);
                        var RESPONSE = cnn.ExecuteScalar("APP_MOBILE_PATCH_TABLESTATE", (object)dynamicParameters1, (IDbTransaction)sqlTransaction, commandType: new CommandType?(CommandType.StoredProcedure));

                            sqlTransaction.Commit();
                            return Ok();
                        }
                        catch (Exception ex)
                        {
                            sqlTransaction.Rollback();
                            return BadRequest(ex.Message);
                            throw;
                        }
                    }
                    cnn.Dispose();

                }
            }
          
        }
    }

