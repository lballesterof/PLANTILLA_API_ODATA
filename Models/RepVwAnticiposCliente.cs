using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwAnticiposCliente
    {
        public string Ruc { get; set; }
        public string NombrePersona { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public DateTime? FecVcto { get; set; }
        public string Mon { get; set; }
        public decimal? ImporteDocumento { get; set; }
        public decimal? Saldo { get; set; }
        public string Observacion { get; set; }
    }
}
