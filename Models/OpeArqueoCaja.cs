using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeArqueoCaja
    {
        public decimal IdArqueo { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string CodigoCajero { get; set; }
        public string Turno { get; set; }
        public string Maquina { get; set; }
        public int Billete200 { get; set; }
        public int Billete100 { get; set; }
        public int Billete50 { get; set; }
        public int Billete20 { get; set; }
        public int Billete10 { get; set; }
        public int Moneda5 { get; set; }
        public int Moneda1 { get; set; }
        public int Moneda05 { get; set; }
        public int Moneda005 { get; set; }
        public int Moneda001 { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal TotalBillete { get; set; }
        public decimal TotalMoneda { get; set; }
        public decimal TotalIngreso { get; set; }
        public decimal TotalRetiro { get; set; }
        public decimal TotalSistema { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaArqueo { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Estado { get; set; }
        public string Moneda { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? Visa { get; set; }
        public decimal? Mastercard { get; set; }
        public decimal? Ripley { get; set; }
        public decimal? Saga { get; set; }
        public decimal? Otros { get; set; }
        public decimal? Contado { get; set; }
        public decimal? Credito { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? Moneda010 { get; set; }
        public decimal? CobradoPorCredito { get; set; }
    }
}
