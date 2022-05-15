using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AcaMatriculaCurso
    {
        public string NumModalidad { get; set; }
        public string Ano { get; set; }
        public decimal IdPersona { get; set; }
        public string NumCurso { get; set; }
        public decimal Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
