using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbAccesoOpcion
    {
        public string CodiGrupUsua { get; set; }
        public string CodiEmpr { get; set; }
        public int CodiOpcion { get; set; }
        public bool FlagNuevo { get; set; }
        public bool FlagModi { get; set; }
        public bool FlagAnul { get; set; }
        public bool FlagElim { get; set; }
        public bool FlagPrint { get; set; }
        public bool FlagBusc { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
    }
}
