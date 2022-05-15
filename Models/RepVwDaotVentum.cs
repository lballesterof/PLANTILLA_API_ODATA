using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwDaotVentum
    {
        public DateTime DdFechaDocu { get; set; }
        public string TipoDocu { get; set; }
        public string Numero { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string CondicionPago { get; set; }
        public string Moneda { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? Tc { get; set; }
    }
}
