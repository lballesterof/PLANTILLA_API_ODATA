using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbUsuario
    {
        public string CodiGrupUsua { get; set; }
        public string LoginUsua { get; set; }
        public string NombUsua { get; set; }
        public string PassUsua { get; set; }
        public string CorreoUsua { get; set; }
        public bool FlagPass { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
    }
}
