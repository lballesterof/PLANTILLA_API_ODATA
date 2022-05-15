using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhPrestamo
    {
        public string Codigo { get; set; }
        public string CdgPara { get; set; }
        public DateTime FechaOperacion { get; set; }
        public decimal Interes { get; set; }
        public string Moneda { get; set; }
        public decimal Importe { get; set; }
        public decimal IdPersona { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
