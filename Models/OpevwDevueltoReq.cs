using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDevueltoReq
    {
        public string NumReq { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? IdReq { get; set; }
    }
}
