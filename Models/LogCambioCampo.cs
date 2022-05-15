using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class LogCambioCampo
    {
        public string Tabla { get; set; }
        public string TipoDocumento { get; set; }
        public string Ruc { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal IdDocumento { get; set; }
        public decimal IdItem { get; set; }
        public string Campo { get; set; }
        public string Referencia1 { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
