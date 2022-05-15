using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhDetallePrestamo
    {
        public string Codigo { get; set; }
        public decimal Item { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public decimal Importe { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
