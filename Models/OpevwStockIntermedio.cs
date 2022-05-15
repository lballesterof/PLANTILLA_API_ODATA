using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwStockIntermedio
    {
        public decimal? Cantidad { get; set; }
        public decimal IdProducto { get; set; }
        public string Almacen { get; set; }
        public string CdgOp { get; set; }
    }
}
