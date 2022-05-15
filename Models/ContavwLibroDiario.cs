using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContavwLibroDiario
    {
        public string CdgCta { get; set; }
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string NumVouc { get; set; }
        public string CdgTas { get; set; }
        public string NumReg { get; set; }
        public DateTime? FecVouc { get; set; }
        public DateTime? FecDocu { get; set; }
        public string GlsVouc { get; set; }
        public string CdgLibro { get; set; }
        public string Correlativo { get; set; }
        public string NumDocu { get; set; }
        public string ContaCodigo { get; set; }
        public string ContaDescripcion { get; set; }
        public decimal? DebNac { get; set; }
        public decimal? HabNac { get; set; }
        public string CdgTope { get; set; }
        public string NumReg2 { get; set; }
        public string CdgTas2 { get; set; }
        public string SwtOfi { get; set; }
        public string SwtPat { get; set; }
        public string CdgCct { get; set; }
        public string CdgMon { get; set; }
        public string CdgTdoc { get; set; }
        public DateTime? VctDocu { get; set; }
    }
}
