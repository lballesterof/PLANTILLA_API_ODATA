using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePedidoMesa
    {
        public decimal IdPedido { get; set; }
        public decimal IdMesa { get; set; }
        public string Piso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal? IdPedidoo { get; set; }
    }
}
