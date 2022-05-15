using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwStockUbicacion
    {
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public decimal Ubicacion01 { get; set; }
        public decimal Ubicacion02 { get; set; }
        public decimal Ubicacion03 { get; set; }
        public decimal Ubicacion04 { get; set; }
        public decimal StockActual { get; set; }
        public decimal? TotalStockUbicacion { get; set; }
        public decimal? Diferencia { get; set; }
        public DateTime? DdFechaActual { get; set; }
    }
}
