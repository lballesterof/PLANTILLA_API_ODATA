using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeRequisicion
    {
        public string Codigo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string NumRequi { get; set; }
        public string Estado { get; set; }
        public string Solicitante { get; set; }
        public decimal? IdPersona { get; set; }
        public string ModPago { get; set; }
        public string Moneda { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? PorIgv { get; set; }
        public decimal? Igv { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? Total { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public string SwtReq { get; set; }
        public string CtaCte { get; set; }
        public string Vehiculo { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string Observacion2 { get; set; }
        public string CdgBcoEmp { get; set; }
        public string CtaCteEmp { get; set; }
        public DateTime? FechMovBco { get; set; }
        public string NumRef { get; set; }
        public string Docs { get; set; }
        public decimal? ImpBco { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? Percepcion { get; set; }
        public decimal? IdOc { get; set; }
    }
}
