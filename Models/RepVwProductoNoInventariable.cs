using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwProductoNoInventariable
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Inventariable { get; set; }
        public DateTime? DdFechaCreacion { get; set; }
        public DateTime? DdFechaUltimaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
