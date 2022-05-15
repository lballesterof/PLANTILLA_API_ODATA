using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleCompromiso
    {
        public string NumComp { get; set; }
        public string NumItm { get; set; }
        public decimal? Imp { get; set; }
        public string CdgPla { get; set; }
        public DateTime? FecVenc { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string CdgTmov { get; set; }
        public string CdgBco { get; set; }
        public string NumCta { get; set; }
        public string CdgGara { get; set; }
        public string NumCor { get; set; }
        public string CorCren { get; set; }
        public string SwtEst { get; set; }
        public string CdgFpag { get; set; }
        public string CdgTmovParent { get; set; }
        public decimal? TipCmb { get; set; }
        public string NumCompParent { get; set; }
        public decimal? IdPersona { get; set; }
    }
}
