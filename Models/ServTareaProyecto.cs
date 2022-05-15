using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ServTareaProyecto
    {
        public decimal IdProyecto { get; set; }
        public decimal Secuencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionTarea { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
        public string EstadoAprobacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
    }
}
