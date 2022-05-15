using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeLimpiezaHabitacion
    {
        public string Habitacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Hora { get; set; }
        public decimal? IdEmpleado { get; set; }
        public string Entrada { get; set; }
        public string Toallas { get; set; }
        public string Sabanas { get; set; }
        public string Salida { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
