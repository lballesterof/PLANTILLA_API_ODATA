using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwGetstockAllwarehousePricelist
    {
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string CdgRef { get; set; }
        public string Nombre { get; set; }
        public string Almacen { get; set; }
        public decimal? StockActual { get; set; }
        public string ListaPrecio { get; set; }
        public string Mon { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string Unidad { get; set; }
    }
}
