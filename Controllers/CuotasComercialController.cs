using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PLANTILLA_API_ODATA.Feature.Cuotas;
using PLANTILLA_API_ODATA.HelpersControllers;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Wrappers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuotasComercialController : BaseApiController
    {

        [HttpGet("GetAllCuotasComercial")]
        public async Task<IActionResult> GetAll([FromQuery] CuotasParameters filter)
        {
            PagedResponse<List<VwMbGetCuotasInmobiliarium>> ilits = null;
            IList<VwMbGetCuotasInmobiliarium> ListConsumed = null;
            ListConsumed = await Mediator.Send(new CuotasQuery
            {
                Ruc = filter.Ruc,
                Año = filter.Año
            });
            var listt = ListConsumed.GroupBy(item => item.Año)
                .Select(grp => new
                {

                    Año = grp.Key,
                    Cuotas = grp.Select(item =>
                    new
                    {
                        item.Mes,
                        item.FechaVencimiento,
                        item.Importe,
                        item.Estado,
                        item.NumeroSerie,
                        item.Cuota
                    })
                }).ToList()
                .OrderBy(x=> x.Año);



            return Ok(listt);

        }
    }
}
