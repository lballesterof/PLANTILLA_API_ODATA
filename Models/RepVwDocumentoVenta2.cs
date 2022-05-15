using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwDocumentoVenta2
    {
        public DateTime Ano { get; set; }
        public DateTime Mes { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string Refletra { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime DdFechaVencimiento { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string FormaPago { get; set; }
        public string Moneda { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal PorIgv { get; set; }
        public decimal Igv { get; set; }
        public decimal? Total { get; set; }
        public string Almacen { get; set; }
    }
}
