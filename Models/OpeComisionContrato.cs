using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeComisionContrato
    {
        public decimal IdPedido { get; set; }
        public string CdgCargo { get; set; }
        public decimal Porcentaje1 { get; set; }
        public decimal? Porcentaje2 { get; set; }
        public decimal TotalContrato { get; set; }
        public decimal ImporteComision { get; set; }
        public DateTime FechaCalculo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal? IdPersona { get; set; }
    }
}
