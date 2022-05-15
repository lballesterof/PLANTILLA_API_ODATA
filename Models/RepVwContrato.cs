using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwContrato
    {
        public string DdFechaCreacion { get; set; }
        public DateTime DdFechaDocumento { get; set; }
        public string NroContrato { get; set; }
        public string Dni { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Deparmento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Telefono { get; set; }
        public string Tdoc { get; set; }
        public string Nro { get; set; }
        public DateTime FechaDocumento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Mon { get; set; }
        public decimal ImporteDocumento { get; set; }
        public decimal PagoDocumento { get; set; }
        public decimal? PagoPendiente { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
