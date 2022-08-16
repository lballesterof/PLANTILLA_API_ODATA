using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwMbGetCuotasInmobiliarium
    {
        public string Ruc { get; set; }
        public string NumeroSerie { get; set; }
        public string FechaVencimiento { get; set; }
        public decimal Cuota { get; set; }
        public string Mes { get; set; }
        public int? Año { get; set; }
        public string Importe { get; set; }
        public string Estado { get; set; }
    }
}
