using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ConfVigencium
    {
        public string CdgParam { get; set; }
        public string Codigo { get; set; }
        public decimal? Valor { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public DateTime FechaVigencia { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
