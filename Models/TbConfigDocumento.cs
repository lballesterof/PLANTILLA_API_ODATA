using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbConfigDocumento
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NombDocu { get; set; }
        public string NombVista { get; set; }
        public string Cadena { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
    }
}
