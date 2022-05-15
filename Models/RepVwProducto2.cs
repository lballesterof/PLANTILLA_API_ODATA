using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwProducto2
    {
        public DateTime? DdFechaHoy { get; set; }
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string Grupo { get; set; }
        public string CodigoBarra { get; set; }
        public string Producto { get; set; }
        public decimal Almacen1 { get; set; }
        public decimal Almacen2 { get; set; }
        public decimal? StockActual { get; set; }
        public string Unidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PrecioMinimo { get; set; }
        public decimal? FactorConversion { get; set; }
    }
}
