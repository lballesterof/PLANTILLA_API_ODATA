using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeEstadoHabitacion
    {
        public decimal? IdReserva { get; set; }
        public decimal? IdCheckin { get; set; }
        public decimal IdHabitacion { get; set; }
        public string Abreviatura { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string SwtSucio { get; set; }
        public decimal? IdDocumento { get; set; }
    }
}
