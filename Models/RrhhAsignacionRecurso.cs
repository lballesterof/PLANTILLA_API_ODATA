using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhAsignacionRecurso
    {
        public decimal IdAsignacion { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Referencia { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
