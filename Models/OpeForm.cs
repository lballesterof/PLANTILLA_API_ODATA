using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeForm
    {
        public int IdForm { get; set; }
        public string NombreArchivo { get; set; }
        public string TituloForm { get; set; }
        public string DescripcionForm { get; set; }
        public string Operaciones { get; set; }
        public string Modulo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Estado { get; set; }
    }
}
