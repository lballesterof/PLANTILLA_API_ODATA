using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwStock
    {
        public decimal IdProducto { get; set; }
        public string CodigoEmpresa { get; set; }
        public string Almacen { get; set; }
        public int StockInicial { get; set; }
        public decimal? StockIngreso { get; set; }
        public decimal? StockSalio { get; set; }
        public decimal? StockActual { get; set; }
        public decimal? StockIngreso2 { get; set; }
        public decimal? StockSalio2 { get; set; }
        public decimal? StockActual2 { get; set; }
    }
}
