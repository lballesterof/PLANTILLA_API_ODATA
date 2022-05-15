using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class CliHistoriaPaciente
    {
        public decimal IdHistoria { get; set; }
        public decimal IdPedido { get; set; }
        public decimal IdPersona { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public decimal? Medico { get; set; }
        public string Especialdad { get; set; }
        public string ExploracionHecha { get; set; }
        public string DiagnosticoHecha { get; set; }
        public string TratamientoHecha { get; set; }
        public string ObservacionHecha { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
