using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeMovimientoDinero
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursalOrigen { get; set; }
        public string CodigoSucursalDestino { get; set; }
        public string EsTraslado { get; set; }
        public string TipoMov { get; set; }
        public decimal IdMovimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string CdgConcepto { get; set; }
        public string Concepto { get; set; }
        public string Tipo { get; set; }
        public decimal IdPersona { get; set; }
        public string TipoDocumento { get; set; }
        public string Numero { get; set; }
        public string Moneda { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Importe { get; set; }
        public string CondicionPago { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Turno { get; set; }
        public string Cobrador { get; set; }
        public string Cajero { get; set; }
        public DateTime? FechaApertura { get; set; }
    }
}
