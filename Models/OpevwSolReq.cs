using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwSolReq
    {
        public string CodigoRequerimiento { get; set; }
        public decimal? IdReq { get; set; }
        public string Estado { get; set; }
        public int? IdProducto { get; set; }
    }
}
