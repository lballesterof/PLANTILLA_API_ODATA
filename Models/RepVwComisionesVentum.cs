using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwComisionesVentum
    {
        public string Vendedor { get; set; }
        public string NumeroPedido { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocu { get; set; }
        public string DdFechaDocumento { get; set; }
        public string DdFechaVencimiento { get; set; }
        public decimal ImporteSoles { get; set; }
        public decimal ImporteDolar { get; set; }
        public decimal Cobrado { get; set; }
        public decimal? PorCobrar { get; set; }
        public decimal Igv { get; set; }
        public decimal? Comision { get; set; }
        public decimal? ComisionPagada { get; set; }
        public decimal? ComisionPorPagar { get; set; }
    }
}
