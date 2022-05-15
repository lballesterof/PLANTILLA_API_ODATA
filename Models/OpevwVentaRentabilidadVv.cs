using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwVentaRentabilidadVv
    {
        public decimal? ValorVentaConNcS { get; set; }
        public decimal? ValorVentaConNcD { get; set; }
        public decimal CostotSoles { get; set; }
        public decimal CostotDolar { get; set; }
        public decimal? MargenSoles { get; set; }
        public decimal? MargenDolar { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string Trimestre { get; set; }
        public string Semestre { get; set; }
        public decimal? Anomes { get; set; }
    }
}
