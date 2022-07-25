using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.DetalleTabla;
using PLANTILLA_API_ODATA.Models.DTO.ListaPrecio;
using PLANTILLA_API_ODATA.Services;
using PLANTILLA_API_ODATA.Services.Helpers.Common;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablasBasicasController : ControllerBase
    {

        private readonly IOpeTablaServices opeTablaServices;

        public TablasBasicasController(IOpeTablaServices opeTablaServices) =>
            this.opeTablaServices = opeTablaServices;

        // GET: api/OpeTablas
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeTabla>> GetAllStudents()
        {
            IQueryable<OpeTabla> retrievedStudents =
                this.opeTablaServices.RetrieveAllTablas();

            return Ok(retrievedStudents);
        }

        // GET: api/OpeTablas
        [HttpGet("Detail")]
        [EnableQuery]
        public ActionResult<IQueryable<OpeDetalleTabla>> GetAllDeails()
        {
            IQueryable<OpeDetalleTabla> retrievedStudents =
                this.opeTablaServices.RetrieveAllDetailTablas();

            return Ok(retrievedStudents);
        }


        // GetListadePrecio
        #region GetListaPrecio

        //private string _connection = @"Data Source=DESKTOP-CKJNAHP;Initial Catalog=Test_Products;User ID=sa;Password=Qz0966lb";
        [HttpGet("Listasdeprecio")]
        public IActionResult GetListaPrecio()
        {
            IEnumerable<Lista_Precio> listado = null;
            using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
            {
                if (db.State == ConnectionState.Closed) db.Open();
                {

                    DynamicParameters cmd = new DynamicParameters();
                    var procedure = "GetDataListaPrecio";

                    listado = db.Query<Lista_Precio>(procedure, commandType: System.Data.CommandType.StoredProcedure);

                }
            }

            return new JsonResult(listado);

        }

        #endregion

    }
}
