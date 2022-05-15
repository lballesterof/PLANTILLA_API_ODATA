using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleLiquidacionm
    {
        public decimal IdDocumento { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Secuencia { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ValorUnitrarioTotal { get; set; }
        public string SwtFact { get; set; }
    }
}
