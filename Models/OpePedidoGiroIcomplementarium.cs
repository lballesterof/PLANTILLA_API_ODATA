using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePedidoGiroIcomplementarium
    {
        public decimal? IdPedido { get; set; }
        public decimal? Secuencia { get; set; }
        public string GiroIcomplementaria { get; set; }
        public decimal? MontoGiroIcomplementaria { get; set; }
        public DateTime? VencGiroIcomplementaria { get; set; }
        public string NoAplica1 { get; set; }
        public string NoAplica2 { get; set; }
        public string NoAplica3 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
