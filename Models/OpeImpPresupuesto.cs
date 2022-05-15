using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeImpPresupuesto
    {
        public decimal IdPresupuesto { get; set; }
        public string Codigo { get; set; }
        public decimal Secuencia { get; set; }
        public string CdgUnidad { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Probabilidad { get; set; }
        public decimal? Total { get; set; }
        public decimal? Preciome { get; set; }
        public decimal? Subtotalme { get; set; }
        public decimal? Totalme { get; set; }
    }
}
