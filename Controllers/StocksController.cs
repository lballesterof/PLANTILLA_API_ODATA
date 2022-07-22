using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANTILLA_API_ODATA.Feature.Stocks;
using PLANTILLA_API_ODATA.HelpersControllers;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Wrappers;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Controllers
{
    [ApiController]
    public class StocksController : BaseApiController
    {
        [HttpGet("GetAllWarehouse")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllStocksWarehouseParameters filter)
        {
            PagedResponse<List<VwGetstockAllwarehousePricelist>> ilits = null;
            IList<VwGetstockAllwarehousePricelist> ListConsumed = null;
            ListConsumed = await Mediator.Send(new GetAllStocksWarehouseQuery
            {
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                Nombre = filter.Nombre,
                Codigo = filter.Codigo,
                CdgRef = filter.CdgRef,
                CodigoBarra = filter.CodigoBarra
            });
            var listt = ListConsumed.GroupBy(item => item.Nombre)
                .Select(grp => new
                {

                    Producto = grp.Key,
                    CodigoBarra = grp.First().CodigoBarra,
                    CodRef = grp.First().CdgRef,
                    Codigo = grp.First().Codigo,
                    Almacen = grp.Select(item =>
                    new
                    {
                        item.Almacen,
                        item.StockActual,
                        item.Unidad,
                        item.ListaPrecio,
                        item.Mon,
                        item.PrecioVenta
                    })
                }).ToList();



            return Ok(listt);

        }
    }
}
