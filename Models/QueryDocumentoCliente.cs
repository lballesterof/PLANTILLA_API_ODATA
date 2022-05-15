using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class QueryDocumentoCliente
    {
        public string Ruc { get; set; }
        public string Persona { get; set; }
        public string IdTd { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Moneda { get; set; }
        public string Mon { get; set; }
        public decimal? ImporteDocumento { get; set; }
        public decimal PagoDocumento { get; set; }
        public decimal? Saldo { get; set; }
        public string Estado { get; set; }
        public string NumRef { get; set; }
        public string Ubicacion { get; set; }
        public string Banco { get; set; }
    }
}
