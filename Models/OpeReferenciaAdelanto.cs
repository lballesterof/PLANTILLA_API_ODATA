using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeReferenciaAdelanto
    {
        public string NumeroCobro { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public int Secuencia { get; set; }
    }
}
