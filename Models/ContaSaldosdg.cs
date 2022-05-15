using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaSaldosdg
    {
        public string AnoSld { get; set; }
        public string MesSld { get; set; }
        public string CdgCta { get; set; }
        public string CdgCct { get; set; }
        public string CdgMon { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public decimal DebNac { get; set; }
        public decimal HabNac { get; set; }
        public decimal DebExt { get; set; }
        public decimal HabExt { get; set; }
        public decimal TipCmb { get; set; }
        public string SwtEst { get; set; }
    }
}
