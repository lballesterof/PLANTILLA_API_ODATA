using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Pedido;
using PLANTILLA_API_ODATA.Services.Pedido;
using System.Threading.Tasks;
using PLANTILLA_API_ODATA.Services.Precuenta;
using Microsoft.AspNetCore.Hosting;
using PLANTILLA_API_ODATA.Reports.Precuenta;

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


		#region Impresion Precuenta
		[HttpGet("Precuenta/{NroPrecuenta}")]
		[Produces("application/pdf", new string[] { })]
		public async Task<IActionResult> ImprimirPrecuenta(string NroPrecuenta)
		{
			PedidoController controller = this;
			TicketPrecuentaPDF.TicketPDF PC = new TicketPrecuentaPDF.TicketPDF();
			return File(new CrearPrecuenta().CrearBoleta(), "application/pdf");
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



	}

}



