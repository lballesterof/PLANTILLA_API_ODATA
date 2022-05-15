using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwOrdenCompra
    {
        public string Codigo { get; set; }
        public int IdOc { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? IdReq { get; set; }
        public string Responsable { get; set; }
        public int IdProducto { get; set; }
    }
}
