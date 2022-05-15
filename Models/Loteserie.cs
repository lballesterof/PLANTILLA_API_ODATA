using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class Loteserie
    {
        public string CodAlm { get; set; }
        public string TpTransac { get; set; }
        public string CodArt { get; set; }
        public string NroSerLote { get; set; }
        public double? Cantidad { get; set; }
        public string Lote { get; set; }
    }
}
