using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANTILLA_API_ODATA.Feature.Stocks;
using PLANTILLA_API_ODATA.HelpersControllers;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Controllers
{
    [ApiController]
    public class StocksController : BaseApiController
    {
        [HttpGet("GetAllWarehouse")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllStocksWarehouseParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllStocksWarehouseQuery
            {
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                Nombre = filter.Nombre,
                Codigo = filter.Codigo,
                CdgRef = filter.CdgRef,
                CodigoBarra = filter.CodigoBarra
            }));
        }
    }
}
