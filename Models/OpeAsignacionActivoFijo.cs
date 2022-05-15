using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeAsignacionActivoFijo
    {
        public int IdAsignacion { get; set; }
        public decimal DafId { get; set; }
        public int IdProducto { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Observacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaInicio { get; set; }

        public virtual OpeDetalleActivoFijo Daf { get; set; }
    }
}
