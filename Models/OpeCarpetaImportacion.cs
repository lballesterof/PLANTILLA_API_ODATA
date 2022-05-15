using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCarpetaImportacion
    {
        public string CiCodigo { get; set; }
        public string CiNombre { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }
    }
}
