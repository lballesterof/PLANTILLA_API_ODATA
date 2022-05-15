using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RqPresupuesto
    {
        public string NumPre { get; set; }
        public string NumPreP { get; set; }
        public string Nombre { get; set; }
        public string Nota { get; set; }
        public string Ano { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
