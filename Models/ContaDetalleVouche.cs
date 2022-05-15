using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaDetalleVouche
    {
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string CdgTas { get; set; }
        public string NumVouc { get; set; }
        public string NumSec { get; set; }
        public string CdgTdoc { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string CdgCct { get; set; }
        public string CdgCta { get; set; }
        public string NumDocu { get; set; }
        public DateTime? FecDocu { get; set; }
        public DateTime? VctDocu { get; set; }
        public string CdgMon { get; set; }
        public decimal? DebNac { get; set; }
        public decimal? HabNac { get; set; }
        public decimal? TipCmb { get; set; }
        public string GlsVouc { get; set; }
        public string SwtVouc { get; set; }
        public string SwtAma { get; set; }
        public decimal? DebExt { get; set; }
        public decimal? HabExt { get; set; }
        public string NumReg { get; set; }
        public string CdgTope { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string CdgTas2 { get; set; }
    }
}
