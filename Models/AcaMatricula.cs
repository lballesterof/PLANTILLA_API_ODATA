using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class AcaMatricula
    {
        public string Ano { get; set; }
        public string NumModalidad { get; set; }
        public decimal IdPersona { get; set; }
        public string DniAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string DireccionAlumno { get; set; }
        public string GradoAcademico { get; set; }
        public string NivelAcademico { get; set; }
        public string SeccionAcademico { get; set; }
        public string Aula { get; set; }
        public string NombreApoderado { get; set; }
        public string DireccionApoderado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
