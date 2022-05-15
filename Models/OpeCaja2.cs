using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCaja2
    {
        public string CdgArea { get; set; }
        public string NumCaja { get; set; }
        public string NumCta { get; set; }
        public string CdgBco { get; set; }
        public string CdgFpag { get; set; }
        public string NumCheq { get; set; }
        public string CdgMon { get; set; }
        public DateTime FecCaja { get; set; }
        public decimal SldCaja { get; set; }
        public decimal ImpCaja { get; set; }
        public decimal TotCaja { get; set; }
        public decimal MaxCaja { get; set; }
        public string SwtCaja { get; set; }
        public string CdgTmov { get; set; }
        public string NumCor { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FecCierre { get; set; }
        public string NumCorcaja { get; set; }
        public string CdgOp { get; set; }
        public string CodigoSucursal { get; set; }
        public string NumRequi { get; set; }
    }
}
