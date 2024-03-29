﻿using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Persona;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using PLANTILLA_API_ODATA.Services.Persona;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        // GET: api/<OpeProductoController>
        private readonly IOpePersonaServices _services;

        public PersonaController(IOpePersonaServices _services) =>
            this._services = _services;




        // GET: api/OpeTablas
        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpePersona>> GetAllStudents()
        {
            IQueryable<OpePersona> retrievedProducts =
                (IQueryable<OpePersona>)this._services.RetrieveAllProductos();

            return Ok(retrievedProducts);
        }



		#region Get Cliente Existe
		[HttpGet("Exist")]
		public async Task<IActionResult> GetClientExist(string RUC)
		{
			IEnumerable<personaresponseDTO> cotizacionVs = (IEnumerable<personaresponseDTO>)null;
			using (IDbConnection db = (IDbConnection)new SqlConnection(Global.ConnectionStrings))
			{
				if (db.State == ConnectionState.Closed)
					db.Open();
				DynamicParameters dynamicParameters1 = new DynamicParameters();
				dynamicParameters1.Add("@RUC", (object)RUC);
				dynamicParameters1.Add("@TIPO_PERSONA", "0002");
				string str = "GET_EXIST_CLIENT";
				IDbConnection cnn = db;
				string sql = str;
				DynamicParameters dynamicParameters2 = dynamicParameters1;
				CommandType? nullable = new CommandType?(CommandType.StoredProcedure);
				int? commandTimeout = new int?();
				CommandType? commandType = nullable;
				cotizacionVs = await cnn.QueryAsync<personaresponseDTO>(sql, (object)dynamicParameters2, commandTimeout: commandTimeout, commandType: commandType);
			}
			return (IActionResult)new JsonResult((object)cotizacionVs);
		}
		#endregion
		#region Crear Cliente
		[HttpPost("CreateClient")]

		public IActionResult CreateCliente([FromBody] personarequestbody objDev)
		{
			using (IDbConnection db = new SqlConnection(Global.ConnectionStrings))
			{
				int cdg_generado = 0;
				if (db.State == ConnectionState.Closed)
					db.Open();
				using (SqlTransaction sqlTransaction = (SqlTransaction)db.BeginTransaction())
				{
					try
					{

						DynamicParameters dynamicParameters1 = new DynamicParameters();
						dynamicParameters1.Add("@CODIGO_EMPRESA", (object)objDev.CODIGO_EMPRESA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ID_PERSONA", (object)objDev.ID_PERSONA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO", (object)objDev.CODIGO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@RUC", (object)objDev.RUC, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@APELLIDO_PATERNO", (object)objDev.APELLIDO_PATERNO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@APELLIDO_MATERNO", (object)objDev.APELLIDO_MATERNO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@NOMBRE", (object)objDev.NOMBRE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@TELEFONO", (object)objDev.TELEFONO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@FAX", (object)objDev.FAX, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@DIRECCION", (object)objDev.DIRECCION, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@EMAIL", (object)objDev.EMAIL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@TIPO_PERSONA", (object)objDev.TIPO_PERSONA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@TIPO", (object)objDev.TIPO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ESTADO", (object)objDev.ESTADO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CODIGO_SUCURSAL", (object)objDev.CODIGO_SUCURSAL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@TIPO_DOCUMENTO", (object)objDev.TIPO_DOCUMENTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@RAZON_SOCIAL", (object)objDev.RAZON_SOCIAL, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@TIPO_CLIENTE", (object)objDev.TIPO_CLIENTE, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@VENDEDOR", (object)objDev.VENDEDOR, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@CONDICION_PAGO", (object)objDev.CONDICION_PAGO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@DEPARTAMENTO", (object)objDev.DEPARTAMENTO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@PROVINCIA", (object)objDev.PROVINCIA, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@DISTRITO", (object)objDev.DISTRITO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@USUARIO", (object)objDev.USUARIO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@ID_GENERADO", (object)objDev.ID_GENERADO, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());
						dynamicParameters1.Add("@MENSAJE", (object)objDev.Mensaje, new DbType?(), new ParameterDirection?(), new int?(), new byte?(), new byte?());

						int num = db.ExecuteScalar<int>("InsertPersona", (object)dynamicParameters1, (IDbTransaction)sqlTransaction, new int?(), new CommandType?(CommandType.StoredProcedure));
						cdg_generado = num;
						sqlTransaction.Commit();

					}
					catch (Exception)
					{
						sqlTransaction.Rollback();
						throw;
					}
				}
				return Ok(cdg_generado);
			}

		}
		#endregion



	}
}
