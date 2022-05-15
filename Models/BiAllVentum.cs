using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class BiAllVentum
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal VentaRealNetaUsd { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public string CondicionPago { get; set; }
        public string Vendedor { get; set; }
    }
}
