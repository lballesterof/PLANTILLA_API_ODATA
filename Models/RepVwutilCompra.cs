using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwutilCompra
    {
        public string Tdoc { get; set; }
        public string Proveedor { get; set; }
        public string Ruc { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public DateTime? DdFechaPeriodo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Correlativo { get; set; }
        public string NumDocu { get; set; }
        public string Moneda { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoBarra { get; set; }
        public string Producto { get; set; }
        public string UnidadCompraProducto { get; set; }
        public decimal? Cantidad { get; set; }
        public string UnidadCompraDocumento { get; set; }
        public decimal? Factor { get; set; }
        public decimal? ImporteSoles { get; set; }
        public string NumGuia { get; set; }
        public int? AñoPeriodo { get; set; }
        public int? MesPeriodo { get; set; }
    }
}
