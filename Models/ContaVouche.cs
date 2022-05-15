using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaVouche
    {
        public string AnoVouc { get; set; }
        public string MesVouc { get; set; }
        public string CdgTas { get; set; }
        public string NumVouc { get; set; }
        public string SwtOfi { get; set; }
        public string SwtPat { get; set; }
        public DateTime? FecVouc { get; set; }
        public string DesVouc { get; set; }
        public decimal? DebTnac { get; set; }
        public decimal? HabTnac { get; set; }
        public string SwtVouc { get; set; }
        public decimal? DebText { get; set; }
        public decimal? HabText { get; set; }
        public string SwtPre { get; set; }
        public string CdgTope { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
