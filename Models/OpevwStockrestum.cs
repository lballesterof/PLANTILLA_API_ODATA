using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwStockrestum
    {
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public decimal IdProducto { get; set; }
        public string Nombre { get; set; }
    }
}
