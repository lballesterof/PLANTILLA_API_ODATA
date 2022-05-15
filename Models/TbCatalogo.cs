using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbCatalogo
    {
        public string CodiCata { get; set; }
        public string CampoUbl { get; set; }
        public string DescCata { get; set; }
        public string OrigCata { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
    }
}
