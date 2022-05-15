using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePedidoPuntaje
    {
        public decimal IdPedido { get; set; }
        public string Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal Puntaje { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
