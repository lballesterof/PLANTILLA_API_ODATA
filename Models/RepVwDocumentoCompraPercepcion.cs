using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwDocumentoCompraPercepcion
    {
        public string RucPrv { get; set; }
        public string Proveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocu { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? DdFechaContabilizacion { get; set; }
        public string NumeroRegistro { get; set; }
        public DateTime? FechaComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public decimal? ImportePercepcion { get; set; }
        public string Observacion { get; set; }
    }
}
