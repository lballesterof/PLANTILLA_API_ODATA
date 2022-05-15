using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeGgPresupuesto
    {
        public decimal IdPresupuesto { get; set; }
        public decimal Secuencia { get; set; }
        public string CdgTabla { get; set; }
        public string Codigo { get; set; }
        public string CdgUnidad { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Participacion { get; set; }
        public decimal? Tiempo { get; set; }
        public decimal? Sueldo { get; set; }
        public decimal? Parcial { get; set; }
        public decimal? Sueldome { get; set; }
        public decimal? Parcialme { get; set; }
    }
}
