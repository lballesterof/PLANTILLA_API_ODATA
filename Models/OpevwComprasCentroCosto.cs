using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwComprasCentroCosto
    {
        public decimal IdDocumento { get; set; }
        public string NumPeriodo { get; set; }
        public string CdgMon { get; set; }
        public string TipoDocu { get; set; }
        public string NumDocu { get; set; }
        public DateTime FechaDocumento { get; set; }
        public decimal? TipoCambio { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FecCmp { get; set; }
        public string RucPrv { get; set; }
        public string Proveedor { get; set; }
        public string CondicionPago { get; set; }
        public string Correlativo { get; set; }
        public string DescripcionConcepto { get; set; }
        public string Glosa { get; set; }
        public string Cuenta { get; set; }
        public string DebeHaber { get; set; }
        public string Tipo { get; set; }
        public string ConSinIgv { get; set; }
        public string Moneda { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImpPro { get; set; }
        public decimal? Dscto { get; set; }
        public decimal? Importef { get; set; }
        public string CentroCosto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Tipo2 { get; set; }
        public string CdgCc { get; set; }
    }
}
