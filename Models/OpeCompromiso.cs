using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCompromiso
    {
        public string NumComp { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string CdgTmov { get; set; }
        public string CdgPla { get; set; }
        public string CdgBco { get; set; }
        public string NumCta { get; set; }
        public string NumCor { get; set; }
        public string CdgMon { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Tea { get; set; }
        public string SwtEst { get; set; }
        public decimal? TipCmb { get; set; }
        public DateTime? FecDocu { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Obs { get; set; }
        public string Beneficiario { get; set; }
        public DateTime? FechaPlazo { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string CodigoSucursal { get; set; }
    }
}
