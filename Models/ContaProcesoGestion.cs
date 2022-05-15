using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ContaProcesoGestion
    {
        public string ContaCodigo { get; set; }
        public string ContaCc { get; set; }
        public string ContaDebe { get; set; }
        public string ContaHaber { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
