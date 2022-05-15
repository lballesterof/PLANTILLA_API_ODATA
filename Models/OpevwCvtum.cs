using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwCvtum
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public DateTime FechaGuia { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
