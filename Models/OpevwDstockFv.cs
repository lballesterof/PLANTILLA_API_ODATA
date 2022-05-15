using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDstockFv
    {
        public string CodigoSucursal { get; set; }
        public int IdProducto { get; set; }
        public decimal? StkIng { get; set; }
        public decimal? StkSal { get; set; }
        public decimal? StkAct { get; set; }
        public string Lote { get; set; }
        public string Serie { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
