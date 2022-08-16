using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using System;
using System.Data;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet("LogoEmpresa")]
        public IActionResult Getlogoempresa()
        {

            using (IDbConnection dbConnection = (IDbConnection)new SqlConnection(Global.ConnectionStrings))
            {
                if (dbConnection.State == ConnectionState.Closed)
                    dbConnection.Open();
                DynamicParameters dynamicParameters1 = new DynamicParameters();
                IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);
                var sql = "select logo_empr from tb_empresa;";
                byte[] result = (byte[])dbConnection.ExecuteScalar(sql, dynamicParameters1);

                //Byte[] b = System.IO.File.ReadAllBytes(result.ToString());   // You can use your own method over here.         
                return File(result, "image/jpeg");
            }

        }



        //[HttpGet("GetAllWarehouse")]
        //public async Task<IActionResult> GetDatagraphics()
        //{
        //    var listt = ListConsumed.GroupBy(item => item.Nombre)
        //    .Select(grp => new
        //    {

        //        Producto = grp.Key,
        //        CodigoBarra = grp.First().CodigoBarra,
        //        CodRef = grp.First().CdgRef,
        //        Codigo = grp.First().Codigo,
        //        Almacen = grp.Select(item =>
        //        new
        //        {
        //            item.Almacen,
        //            item.StockActual,
        //            item.Unidad,
        //            item.ListaPrecio,
        //            item.Mon,
        //            item.PrecioVenta
        //        })
        //    }).ToList();
        //    return Ok(listt);

        //}


    }

}
