using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwOrdenPedidoLetra
    {
        public string NumeroPedido { get; set; }
        public DateTime DdFechaPedido { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public string Letras { get; set; }
    }
}
