using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetallePlanFabricacion
    {
        public string Codigo { get; set; }
        public int IdProducto { get; set; }
        public decimal AProducir { get; set; }
        public decimal Producido { get; set; }
        public int? Secuencia { get; set; }
    }
}
