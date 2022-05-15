using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContavwDetVoucheCtag
    {
        public string CdgCta { get; set; }
        public decimal? DebNac { get; set; }
        public decimal? HabNac { get; set; }
        public decimal? DebExt { get; set; }
        public decimal? HabExt { get; set; }
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string ContaDescripcion { get; set; }
        public string CdgTas { get; set; }
        public string CdgAnal { get; set; }
        public string SwtOfi { get; set; }
        public string SwtPat { get; set; }
    }
}
