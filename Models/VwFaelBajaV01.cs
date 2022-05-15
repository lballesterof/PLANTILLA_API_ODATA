using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwFaelBajaV01
    {
        public string ConfRazonSocial { get; set; }
        public string ConfRuc { get; set; }
        public string TipoDocuEmpr { get; set; }
        public DateTime FechDocu { get; set; }
        public string TipoDocuDocu { get; set; }
        public string Serie { get; set; }
        public decimal? Correlativo { get; set; }
        public string Motivo { get; set; }
        public int NumeItem { get; set; }
        public string IdBaja { get; set; }
        public string FechGene { get; set; }
        public string VersionUbl { get; set; }
        public string VersionEstructura { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
    }
}
