using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCostoRealOf
    {
        public string Anomes { get; set; }
        public string IdOf { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdInsumo { get; set; }
        public decimal CostoSol { get; set; }
        public decimal CostoDol { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal CantidadProducidad { get; set; }
        public decimal? IdGuia { get; set; }
        public decimal? CantidadInsumo { get; set; }
        public decimal? SaldoGuia { get; set; }
        public decimal? IdGuiaIng { get; set; }
    }
}
