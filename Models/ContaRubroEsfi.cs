using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaRubroEsfi
    {
        public string SwtEf { get; set; }
        public string CdgRub { get; set; }
        public string DesRub { get; set; }
        public string SwtRub { get; set; }
        public string SwtAp { get; set; }
        public string SwtFn { get; set; }
        public string FtrRub { get; set; }
        public string OrdRub { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
