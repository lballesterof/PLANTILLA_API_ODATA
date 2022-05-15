using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeGastoAdicional
    {
        public string Tipo { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Ruc { get; set; }
        public string CdgGasto { get; set; }
        public decimal Importe { get; set; }
        public string CdgMedi { get; set; }
        public decimal Secuencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
