using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwutilAlmacen
    {
        public decimal IdDocumento { get; set; }
        public DateTime DdFechaMovimiento { get; set; }
        public string FechaMovimiento { get; set; }
        public string MovimientoAlmacen { get; set; }
        public string Tdoc { get; set; }
        public string Ruc { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string NumDocu { get; set; }
        public string Moneda { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string Producto { get; set; }
        public string CantidadCompra { get; set; }
        public decimal? PrecioUnitarioSoles { get; set; }
        public string UnidadCompraProducto { get; set; }
        public string UnidadAlmacen { get; set; }
        public string UnidadAlmacenProducto { get; set; }
        public decimal? FactorProducto { get; set; }
        public decimal? FactorAlmacen { get; set; }
    }
}
