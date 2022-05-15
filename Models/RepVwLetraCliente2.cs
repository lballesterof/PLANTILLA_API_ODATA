using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwLetraCliente2
    {
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Distrito { get; set; }
        public string Telefono { get; set; }
        public string Garante { get; set; }
        public string TelefonoGarante { get; set; }
        public string Contrato { get; set; }
        public string Letra { get; set; }
        public decimal? Importe { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int? DiasVencidos { get; set; }
        public string Estado { get; set; }
    }
}
