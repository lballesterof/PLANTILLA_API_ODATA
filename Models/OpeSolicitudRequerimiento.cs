using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSolicitudRequerimiento
    {
        public decimal IdRequerimiento { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Solicitante { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public decimal? IdProyecto { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAprobacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
    }
}
