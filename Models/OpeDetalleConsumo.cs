using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleConsumo
    {
        public int IdConsumo { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Vendido { get; set; }
        public decimal Baja { get; set; }
        public int Secuencia { get; set; }
    }
}
