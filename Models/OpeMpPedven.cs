using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeMpPedven
    {
        public decimal Orden { get; set; }
        public decimal IdPedido { get; set; }
        public string CdgMon { get; set; }
        public string CdgFp { get; set; }
        public string CdgMp { get; set; }
        public decimal Imp { get; set; }
    }
}
