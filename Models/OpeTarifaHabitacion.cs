using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTarifaHabitacion
    {
        public DateTime Fecha { get; set; }
        public string Regimen { get; set; }
        public string TipoHabitacion { get; set; }
        public decimal Precio { get; set; }
        public string Concepto { get; set; }
        public string CargoPersona { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
