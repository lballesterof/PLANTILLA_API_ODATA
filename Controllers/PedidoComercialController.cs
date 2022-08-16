﻿using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.Models.DTO.Pedido;
using PLANTILLA_API_ODATA.Models.DTO.Pedido.PDF;
using PLANTILLA_API_ODATA.Models.DTO.Pedido.Pedidosend;
using PLANTILLA_API_ODATA.Models.DTO.Pedido.Request;
using PLANTILLA_API_ODATA.Reports.PDFPedido;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using PLANTILLA_API_ODATA.Services.Pedido;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoComercialController : ControllerBase
    {
        #region Constructor
        private readonly IOpePedidoService _services;
        IWebHostEnvironment _oHostEnvironment;
        public PedidoComercialController(IOpePedidoService _services, IWebHostEnvironment oHostEnvironment)
        {
            this._services = _services;
            this._oHostEnvironment = oHostEnvironment;
        }
        #endregion
        #region GetAlls Pedidos
        [HttpGet("{cdg_ven}")]
        public async Task<IActionResult> GetAll(string cdg_ven)
        {
            IEnumerable<Pedido> listado = null;
            using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed) db.Open();
                {
                    DynamicParameters cmd = new DynamicParameters();
                    cmd.Add("@CDG_VENDEDOR", cdg_ven);
                    var procedure = "GetDataPedido";

                    listado = await db.QueryAsync<Pedido>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure);

                }
            }

            return new JsonResult(listado);

        }

        #endregion
        #region GetPedidoID
        [HttpGet("MS/{Id_pedido}")]
        public async Task<IActionResult> PedidoID(string Id_pedido)
        {
            MPedido cotizacionVs = new MPedido();
            using (IDbConnection db = (IDbConnection)new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters dynamicParameters1 = new DynamicParameters();
                dynamicParameters1.Add("@ID_PEDIDO", (object)Id_pedido);
                string str = "GET_PEDIDO_ID";
                IDbConnection cnn = db;
                string sql = str;
                DynamicParameters dynamicParameters2 = dynamicParameters1;
                CommandType? nullable = new CommandType?(CommandType.StoredProcedure);
                int? commandTimeout = new int?();
                CommandType? commandType = nullable;
                cotizacionVs = cnn.QueryFirstOrDefaultAsync<MPedido>(sql, (object)dynamicParameters2, commandTimeout: commandTimeout, commandType: commandType).Result;
                sql = "GET_DETALLE_PEDIDO_ID";
                cotizacionVs.DetDevolucion = cnn.Query<DPedido>(sql, (object)dynamicParameters2, commandTimeout: commandTimeout, commandType: commandType).AsList();

            }
            return (IActionResult)new JsonResult((object)cotizacionVs);
        }
        #endregion
        #region Get Detalle Pedido
        [HttpGet("DT/{Id_pedido}")]
        public async Task<IActionResult> GetDPed(string Id_pedido)
        {
            IDbConnection db;
            IEnumerable<DPedido> dcotizacionVs = (IEnumerable<DPedido>)null;
            using (db = (IDbConnection)new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters dynamicParameters1 = new DynamicParameters();
                dynamicParameters1.Add("@ID_PEDIDO", (object)Id_pedido);
                string str = "GET_DETALLE_PEDIDO_ID";
                IDbConnection cnn = db;
                string sql = str;
                DynamicParameters dynamicParameters2 = dynamicParameters1;
                CommandType? nullable = new CommandType?(CommandType.StoredProcedure);
                int? commandTimeout = new int?();
                CommandType? commandType = nullable;
                dcotizacionVs = await cnn.QueryAsync<DPedido>(sql, (object)dynamicParameters2, commandTimeout: commandTimeout, commandType: commandType);
            }
            return (IActionResult)new JsonResult((object)dcotizacionVs);
        }
        #endregion
        #region Creación de Pedido
        [HttpPost("CreateOrder")]
        public IActionResult InsertPedido([FromBody] CabeceraPedidoDTO entity)
        {
            CabeceraPedidoDTO newpedido = _services.SavePedidoComercial(entity);
            return Ok(newpedido);
        }
        #endregion
        #region Pdf Pedido
        [HttpGet("pdf/{id_ped}")]
        [Produces(contentType: "application/pdf")]
        public async Task<IActionResult> PdfPedido(string id_ped)
        {
            List<Pedido> lstorder = new List<Pedido>();
            List<DPedidoV> lstorderp = new List<DPedidoV>();
            PedidoComercialController pedidoComercialController = this;

            IEnumerable<Pedido> listado = null;
            IEnumerable<DPedidoV> listadop = null;

            using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed) db.Open();
                {
                    DynamicParameters cmd = new DynamicParameters();
                    cmd.Add("@ID_PEDIDO", id_ped);
                    var procedure = "GetDataPedidoID";
                    var procedure2 = "GetDataPedidoDetalleID";

                    listado = db.Query<Pedido>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure);
                    lstorder = listado.ToList();
                    listadop = db.Query<DPedidoV>(procedure2, cmd, commandType: System.Data.CommandType.StoredProcedure);
                    lstorderp = listadop.ToList();

                }
            }
            RPedido pdfpedido = new RPedido();
            return pedidoComercialController.File(pdfpedido.Report(lstorder, lstorderp), "application/pdf");


        }
        #endregion
    }
}
