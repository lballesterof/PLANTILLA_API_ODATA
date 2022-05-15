using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaLineaEsfi
    {
        public string SwtEf { get; set; }
        public string CdgRub { get; set; }
        public string CdgLin { get; set; }
        public string DesLin { get; set; }
        public string OrdLin { get; set; }
        public string SwtLin { get; set; }
        public string SwtFn { get; set; }
        public string Tipo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
