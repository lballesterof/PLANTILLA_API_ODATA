using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeHabitacion
    {
        public decimal IdHabitacion { get; set; }
        public string Abreviatura { get; set; }
        public string Nombre { get; set; }
        public string TipoHabitacion { get; set; }
        public string GrupoHabitacion { get; set; }
        public string NoHabitacion { get; set; }
        public decimal PaxMax { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
