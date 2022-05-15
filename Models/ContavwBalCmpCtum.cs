using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContavwBalCmpCtum
    {
        public string CdgCta { get; set; }
        public decimal? DebeS { get; set; }
        public decimal? HaberS { get; set; }
        public decimal? DebeD { get; set; }
        public decimal? HaberD { get; set; }
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string ContaDescripcion { get; set; }
        public decimal? DebeAs { get; set; }
        public decimal? HaberAs { get; set; }
        public decimal? DebeAd { get; set; }
        public decimal? HaberAd { get; set; }
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
        public string SwtOfi { get; set; }
        public string SwtPat { get; set; }
    }
}
