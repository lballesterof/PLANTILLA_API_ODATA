using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class CliCitum
    {
        public decimal IdCita { get; set; }
        public decimal IdPersona { get; set; }
        public string Especialidad { get; set; }
        public DateTime FechaCita { get; set; }
        public DateTime FechaProgramada { get; set; }
        public string Horario { get; set; }
        public string Turno { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
