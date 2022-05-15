using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ConfAlu
    {
        public string Alerta { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public string Estado { get; set; }
        public decimal? AvisarAntes { get; set; }
        public decimal? AvisarHasta { get; set; }
        public string Usuarios { get; set; }
        public decimal? Frecuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
