using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Pedido;
using PLANTILLA_API_ODATA.Services.Pedido;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using PLANTILLA_API_ODATA.Reports.Precuenta;
using Microsoft.AspNetCore.OData.Query;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using System;

namespace PLANTILLA_API_ODATA.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PedidoController : ControllerBase
	{

		#region Constructor
		private readonly IOpePedidoService _services;
		IWebHostEnvironment _oHostEnvironment;
		public PedidoController(IOpePedidoService _services, IWebHostEnvironment oHostEnvironment)
		{
			this._services = _services;
			this._oHostEnvironment = oHostEnvironment;
		}
		#endregion
		#region GetAll
		[HttpGet]
		[EnableQuery]
		public ActionResult<IQueryable<OpePedido>> GetAllStudents()
		{
			IQueryable<OpePedido> retrievedProducts =
				this._services.RetrieveAllPedidos();

			return Ok(retrievedProducts);
		}
		#endregion
		#region Impresion Precuenta
		[HttpGet("Precuenta")]
	
		public IActionResult ImprimirPrecuenta(string idPedido)
		{
			
			return Ok(_services.PrecuentafinbyId(idPedido));
		}
		#endregion
		#region Pedido Detalle Cuenta
		[HttpGet("PedidoMesa/{id}")]
		public async Task<IActionResult> GetPedidoMesa(string id)
		{
			IEnumerable<OpeDetallePedidoDTO> listado = null;
			using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
			{
				if (db.State == ConnectionState.Closed) db.Open();
				{
					DynamicParameters cmd = new DynamicParameters();
					cmd.Add("@ID_PEDIDO", id);
					var procedure = "GetDataPedidoDetalleID";

					listado = db.Query<OpeDetallePedidoDTO>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure);

				}
			}

			return new JsonResult(listado);
		}

		#endregion
		#region Creación de Pedido
		[HttpPost("CreateOrder")]
		public IActionResult InsertPedido([FromBody] CabeceraPedidoDTO entity)
		{
			CabeceraPedidoDTO newpedido = _services.SavePedido(entity);
			return Ok(newpedido);
		}
		#endregion
		#region Comandar
		[HttpGet("Comanda")]
		public IActionResult ImprimirComanda(string idPedido)
		{

			return Ok(_services.ComandarfinbyIdAndComanda(idPedido));
		}
        #endregion


        #region Actualizar detalle comandado
        [HttpPut("EstadoComandado/{comanda}/{idpedido}")]
        public IActionResult UpdateEstado(string comanda, int idpedido)
        {

            using (IDbConnection cnn = (IDbConnection)new SqlConnection(Global.ConnectionStrings))
            {
                cnn.Open();
                using (SqlTransaction sqlTransaction = (SqlTransaction)cnn.BeginTransaction())
                {
                    try
                    {
                        var parameters = new { COMANDA = comanda, IDPEDIDO = idpedido };
                        IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);
                        var sql = "UPDATE OPE_DETALLE_PEDIDO SET FLAG_COLOR = '1' WHERE COMANDA =@COMANDA AND ID_PEDIDO = @IDPEDIDO;";
                        var result = dbII.Query(sql, parameters);
                        return NoContent();
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
        #endregion
    }


}



