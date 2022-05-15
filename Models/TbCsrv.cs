using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbCsrv
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public string TipoDocuClie { get; set; }
        public string NumeDocuClie { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
