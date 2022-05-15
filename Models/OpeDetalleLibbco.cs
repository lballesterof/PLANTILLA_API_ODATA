using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleLibbco
    {
        public string CdgBco { get; set; }
        public string NumCta { get; set; }
        public string NumCor { get; set; }
        public string NumItm { get; set; }
        public string CdgTdoc { get; set; }
        public string NumDocu { get; set; }
        public string CdgTmov { get; set; }
        public decimal ImpDebe { get; set; }
        public decimal ImpHaber { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string MonOri { get; set; }
        public string CdgCc { get; set; }
        public int? NumItm2 { get; set; }

        public virtual OpeLibbco OpeLibbco { get; set; }
    }
}
