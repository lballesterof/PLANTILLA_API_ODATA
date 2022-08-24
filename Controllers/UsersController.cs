using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Ocsp;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using PLANTILLA_API_ODATA.Services.Persona;
using PLANTILLA_API_ODATA.Services.Usuario;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.util;

namespace PLANTILLA_API_ODATA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
      
        private readonly IOpeUsuarioService opeUsuarioService;
        private readonly IWebHostEnvironment Env;
        public UsersController(IOpeUsuarioService opeUsuarioService, IWebHostEnvironment env)
        {
            this.opeUsuarioService = opeUsuarioService;
            this.Env = env;
        }


        private string ipAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<OpeUsuario>> GetAllUsers()
        {
            IQueryable<OpeUsuario> retrieveAllUsers =
                this.opeUsuarioService.RetrieveAllUsers();

            return Ok(retrieveAllUsers);
        }

        [HttpPost("Login")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest model)
        {
            AuthenticateResponse response = opeUsuarioService.Authenticate(model, ipAddress());

            if (response == null)
            {
                return BadRequest(new { message = "Usuario o Contraseña Incorrecta" });
            }
            else
            {
                return Ok(response);

            }

            //setTokenCookie(response.RefreshToken);

        }
        [HttpPost("LoginComercial")]
        public IActionResult AuthenticateComercial([FromBody] AuthenticateRequest model)
        {
            AuthenticateResponse response = opeUsuarioService.AuthenticateComercial(model, ipAddress());

            if (response == null)
            {
                return BadRequest(new { message = "Usuario o Contraseña Incorrecta" });
            }
            else
            {
                return Ok(response);

            }

            //setTokenCookie(response.RefreshToken);

        }



        [HttpPost("LoginClienteCuota")]
        public IActionResult AuthenticateClienteCuota([FromBody] AuthenticateClienteCuotaRequest model)
        {
            AuthenticateResponse response = opeUsuarioService.AuthenticateClienteCuotas(model, ipAddress());

            if (response == null)
            {
                return BadRequest(new { message = "Usuario o Contraseña Incorrecta" });
            }
            else
            {
                return Ok(response);

            }

            //setTokenCookie(response.RefreshToken);

        }


        [HttpPost("LoginClienteCuota/RecoveryPassword")]
        public IActionResult RecoveryPassword([FromBody] RecoveryPasswordCuotas model)
        {
            IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);
            var parametersI = new { DocIdent = model.DocIdentidad };
            var sqlI = "SELECT EMAIL,NOMBRE  FROM OPE_PERSONA WHERE TIPO_PERSONA = '0002' AND RUC = @DocIdent ;";
            ReceiveMailerCuotas resultI = dbII.QuerySingleOrDefault<ReceiveMailerCuotas>(sqlI, parametersI);

            if (resultI == null)
            {
                return BadRequest(new { message = "USUARIO NO POSEE DIRECCION DE CORREO ASOCIADO" });
            }
            else
            {
                int CodeGenerte = Utils.RecoveryCode();
                string BodyMessage = CorreoRecuperacionPassword.BodyHTML(resultI.NOMBRE, CodeGenerte.ToString());
                bool mail = SendMail.mail (resultI.EMAIL, $"Recovery Password AppCuotas {resultI.NOMBRE}", BodyMessage);
                  
                if (!mail == true)
                {

                    return BadRequest(new { message = "NO SE LOGRO ENVIAR EL CORREO POR FAVOR CONTACTARSE CON SU PROVEEDOR DE SERVICIO" });
                   
                }


                var sqlII = $"UPDATE OPE_PERSONA SET CODIGO_ACTIVACION = {CodeGenerte} WHERE TIPO_PERSONA = '0002' AND RUC = @DocIdent ;";
                dbII.Query(sqlII, parametersI);
                dbII.Dispose();
                return Ok("Mensaje Enviado Satisfactoriamente");
            }

        }


        [HttpPost("LoginClienteCuota/ConfirmCode")]
        public IActionResult ConfirmCodeRecovery([FromBody] RecoveryPasswordCode model)
        {
            IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);
            var parametersI = new { DocIdent = model.DocIdentidad, Code = model.Code };
            var sqlI = "SELECT CODIGO_ACTIVACION,NOMBRE  FROM OPE_PERSONA WHERE TIPO_PERSONA = '0002' AND RUC = @DocIdent  AND CODIGO_ACTIVACION = @Code;";
            ReceiveMailerCuotas resultI = dbII.QuerySingleOrDefault<ReceiveMailerCuotas>(sqlI, parametersI);

            if (resultI == null)
            {
                return BadRequest(new { message = "CÓDIGO DE VALIDACIÓN INVÁLIDO" });
            }

            return Ok("Validación Exitosa");

        }


        [HttpPost("LoginClienteCuota/ResendCode")]
        public IActionResult ResendCodeRecovery([FromBody] RecoveryPasswordCuotas model)
        {
            IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);
            var parametersI = new { DocIdent = model.DocIdentidad };
            var sqlI = "SELECT EMAIL,NOMBRE  FROM OPE_PERSONA WHERE TIPO_PERSONA = '0002' AND RUC = @DocIdent ;";
            ReceiveMailerCuotas resultI = dbII.QuerySingleOrDefault<ReceiveMailerCuotas>(sqlI, parametersI);

            if (resultI == null)
            {
                return BadRequest(new { message = "USUARIO NO POSEE DIRECCION DE CORREO ASOCIADO" });
            }
            else
            {
                int CodeGenerte = Utils.RecoveryCode();
                string BodyMessage = CorreoRecuperacionPassword.BodyHTML(resultI.NOMBRE, CodeGenerte.ToString());
                bool mail = SendMail.mail(resultI.EMAIL, $"Recovery Password AppCuotas {resultI.NOMBRE}", BodyMessage);

                if (!mail == true)
                {

                    return BadRequest(new { message = "NO SE LOGRO ENVIAR EL CORREO POR FAVOR CONTACTARSE CON SU PROVEEDOR DE SERVICIO" });

                }


                var sqlII = $"UPDATE OPE_PERSONA SET CODIGO_ACTIVACION = {CodeGenerte} WHERE TIPO_PERSONA = '0002' AND RUC = @DocIdent ;";
                dbII.Query(sqlII, parametersI);
                dbII.Dispose();
                return Ok("Mensaje Enviado Satisfactoriamente");
            }

        }


        [HttpPost("LoginClienteCuota/UpdatePassword")]
        public IActionResult UpdaterecoveryPassword([FromBody] NewPasswordRecoveryCuotas model)
        {
            IDbConnection dbII = new SqlConnection(Global.ConnectionStrings);


            var parametersI = new { DocIdent = model.DocIdentidad, NewPassword = model.NewPassword };
            var sqlI = "UPDATE OPE_PERSONA SET APP_CONTRASENA =@NewPassword , FLOGIN = 0 WHERE TIPO_PERSONA = '0002' AND RUC = @DocIdent";
            var resultI = dbII.Query(sqlI, parametersI);

            if (resultI == null)
            {
                return BadRequest(new { message = "CÓDIGO DE VALIDACIÓN INVÁLIDO" });
            }



            return Ok("Actualizacion Exitosa");

        }
    }
}
