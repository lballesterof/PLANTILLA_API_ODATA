using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleRecetum
    {
        public int IdProducto { get; set; }
        public int IdProducto2 { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? ValorSol { get; set; }
        public decimal? ValorDol { get; set; }
        public string Intermedio { get; set; }
    }
}
