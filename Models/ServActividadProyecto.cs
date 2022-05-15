using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServActividadProyecto
    {
        public decimal IdProyecto { get; set; }
        public decimal Secuencia { get; set; }
        public decimal IdActividad { get; set; }
        public string NombreActividad { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? VvUnit { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? HoraEstimada { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Moneda { get; set; }
        public decimal? Tc { get; set; }
    }
}
