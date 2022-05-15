using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleHabitacion
    {
        public decimal IdSecuencia { get; set; }
        public decimal IdHabitacion { get; set; }
        public decimal? IdEmpleado { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string Hora { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Observacion { get; set; }
        public string TipoDetalle { get; set; }
    }
}
