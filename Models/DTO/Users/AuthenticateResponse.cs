using PLANTILLA_API_ODATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Models.DTO.Users
{
    public class AuthenticateResponse
    {

        public string USUARIO {get;set;}
        public string NOMBREUSUARIO {get;set;}
        public string CODIGO_EMPRESA {get;set;}
        public int ID_CLIENTE {get;set;}
        public string POR_IGV {get;set;}
        public string CDGMONEDA {get;set;}
        public string VALIDEZ {get;set;}
        public string CDGPAGO {get;set;}
        public string SUCURSAL {get;set;}
        public string NOMBREMOZO { get;set;}
        public string USUARIOAUTORIZA {get;set;}
        public string USUARIOCREACION {get;set;}
        public string DESCUENTO {get;set;}
        public string SERIEPEDIDO {get;set;}
        public string ESTADOPEDIDO {get;set;}
        public string TIPOCAMBIO {get;set;}
        public string JwtToken {get;set;}
        public string FACTURA_ADELANTADA => "0";
        public string ID_COTIZACION => "0";
        public string PUNTO_VENTA => "0";
        public string REDONDEO => "0";
        public string? MOTIVO => null;
        public string? CORRELATIVO => null;
        public string? CENTRO_COSTO = null;
        public string RefreshToken {get;set;}
        public string? CDG_VENDEDOR { get; set; }
        public string? RUC { get; set; }
        public string? NOMBRE { get; set; }
        public int? FLOGIN { get; set; }
        public AuthenticateResponse(OpeUsuarioDTO user, string jwtToken, string refreshToken)
        {
            USUARIO = user.USUARIO;
            NOMBREUSUARIO = user.NOMBREUSUARIO;
            CODIGO_EMPRESA = user.CODIGO_EMPRESA;
            ID_CLIENTE = user.ID_CLIENTE;
            POR_IGV = user.POR_IGV;
            CDGMONEDA = user.CDGMONEDA;
            VALIDEZ = user.VALIDEZ;
            CDGPAGO = user.CDGPAGO;
            SUCURSAL = user.SUCURSAL;
            USUARIOAUTORIZA = user.USUARIOAUTORIZA;
            USUARIOCREACION = user.USUARIOCREACION;
            DESCUENTO = user.DESCUENTO;
            SERIEPEDIDO = user.SERIEPEDIDO;
            ESTADOPEDIDO = user.ESTADOPEDIDO;
            TIPOCAMBIO = user.TIPOCAMBIO;
            NOMBREMOZO = user.NOMBREMOZO;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
            CDG_VENDEDOR = user.CDG_VENDEDOR;
            RUC = user.RUC;
            NOMBRE = user.NOMBRE;
            FLOGIN = user.FLOGIN;
        }
    }
}