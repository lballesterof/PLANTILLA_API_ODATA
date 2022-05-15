using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeSeguimientoPedi
    {
        public decimal IdProgramacion { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public string Tipo { get; set; }
        public int Secuencia { get; set; }
        public DateTime FechaReprogramada { get; set; }
        public string Motivo { get; set; }
        public string Comentario { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
