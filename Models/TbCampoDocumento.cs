using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class TbCampoDocumento
    {
        public string CodiEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string CodiCampo { get; set; }
        public int Secuencia { get; set; }
        public string NombCampo { get; set; }
        public bool FlagCabDet { get; set; }
        public bool FlagAlfaNume { get; set; }
        public bool FlagObli { get; set; }
        public int? CantDeci { get; set; }
        public string DescCampo { get; set; }
        public int LongCampo { get; set; }
        public string UsuaCrea { get; set; }
        public DateTime FechCrea { get; set; }
        public string UsuaModi { get; set; }
        public DateTime? FechModi { get; set; }
        public string Estado { get; set; }
    }
}
