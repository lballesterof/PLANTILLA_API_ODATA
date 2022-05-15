using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwDetalleDocumentoCompra
    {
        public string Nombre { get; set; }
        public string NumDocu { get; set; }
        public string Proveedor { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public DateTime DdFechaVencimiento { get; set; }
        public DateTime? DdFechaContabilizacion { get; set; }
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
        public string CentroCosto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
