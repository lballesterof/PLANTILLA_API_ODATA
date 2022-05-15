using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeMpDocven
    {
        public decimal Orden { get; set; }
        public decimal IdDocumento { get; set; }
        public string CdgMon { get; set; }
        public string CdgFp { get; set; }
        public string CdgMp { get; set; }
        public decimal Imp { get; set; }
        public decimal? Propina { get; set; }
    }
}
