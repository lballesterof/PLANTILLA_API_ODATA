using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwLetraCliente
    {
        public string NroCanje { get; set; }
        public string TipoDocu { get; set; }
        public string NroDocumento { get; set; }
        public DateTime? DdFechaGiro { get; set; }
        public DateTime DdVencimiento { get; set; }
        public string Aceptante { get; set; }
        public string Seccion { get; set; }
        public string Moneda { get; set; }
        public decimal Importe { get; set; }
        public int Plazo { get; set; }
        public string Facturas { get; set; }
        public string NroBanco { get; set; }
        public string Referencia { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string RucAval { get; set; }
        public string NombreAval { get; set; }
        public string DireccionAval { get; set; }
        public string TelefonoAval { get; set; }
        public string Estado { get; set; }
    }
}
