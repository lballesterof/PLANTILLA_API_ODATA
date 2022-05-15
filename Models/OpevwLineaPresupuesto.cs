using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwLineaPresupuesto
    {
        public string CdgConcepto { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public DateTime? FecDocu { get; set; }
        public decimal IdPresupuesto { get; set; }
        public string CdgCc { get; set; }
        public string NomCc { get; set; }
        public string Concepto { get; set; }
        public decimal? CostoSoles { get; set; }
        public decimal? CostoDolar { get; set; }
        public decimal? VvSoles { get; set; }
        public decimal? VvDolar { get; set; }
    }
}
