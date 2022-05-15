using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContavwCierreAnual
    {
        public string CdgCta { get; set; }
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string ContaDescripcion { get; set; }
        public decimal? DebNac { get; set; }
        public decimal? HabNac { get; set; }
        public decimal? DebExt { get; set; }
        public decimal? HabExt { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public DateTime? FecDocu { get; set; }
        public DateTime? VctDocu { get; set; }
        public DateTime? FecVouc { get; set; }
        public string CdgMon { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string CdgCct { get; set; }
        public string ContaTipoCuenta { get; set; }
        public string ContaMovimiento { get; set; }
        public string ContaTipoAnalisis { get; set; }
        public string ContaTipoAnalitica { get; set; }
        public decimal? TipCmb { get; set; }
        public string GlsVouc { get; set; }
        public string NumReg { get; set; }
        public string ContaMonetaria { get; set; }
        public string SwtAma { get; set; }
        public string ContaMonetariaEspecial { get; set; }
    }
}
