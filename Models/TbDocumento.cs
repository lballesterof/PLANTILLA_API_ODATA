using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbDocumento
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string CodiCampo { get; set; }
        public string NumeDocu { get; set; }
        public int Secuencia { get; set; }
        public int SecuDocu { get; set; }
        public DateTime FechDocu { get; set; }
        public decimal ValorN { get; set; }
        public string ValorA { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
    }
}
