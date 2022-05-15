using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePedidoPagoIhoy
    {
        public decimal IdPedido { get; set; }
        public decimal Secuencia { get; set; }
        public decimal MontoPagoInicialHoy { get; set; }
        public string BancoTarjetaPagoInicialHoy { get; set; }
        public string ReferenciaPagoInicialHoy { get; set; }
        public DateTime? FechaPagoInicialHoy { get; set; }
        public string FormaPagoInicialHoy { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
