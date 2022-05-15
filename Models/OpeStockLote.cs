using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeStockLote
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public int IdProducto { get; set; }
        public string Lote { get; set; }
        public decimal CantidadIngresada { get; set; }
        public decimal CantidadSalida { get; set; }
        public decimal StockActual { get; set; }
        public string CodigoUnidad { get; set; }
        public string Serie { get; set; }
    }
}
