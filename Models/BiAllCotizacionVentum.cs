using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class BiAllCotizacionVentum
    {
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal VentaRealNetaUsd { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public string CondicionPago { get; set; }
        public string Vendedor { get; set; }
        public decimal? AnoCierre { get; set; }
        public string MesCierre { get; set; }
        public decimal? Al30 { get; set; }
        public decimal? Al50 { get; set; }
        public decimal? Al80 { get; set; }
    }
}
