using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbPassCliente
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public byte[] PassClie { get; set; }
    }
}
