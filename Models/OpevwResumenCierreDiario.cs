using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwResumenCierreDiario
    {
        public string TipoOperacion { get; set; }
        public string CodigoSucursal { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public string Cp { get; set; }
    }
}
