using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwFaelContingencium
    {
        public decimal? MContingencia { get; set; }
        public DateTime FechDocu { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocuMreg { get; set; }
        public string NumeDocu { get; set; }
        public string NumeFinal { get; set; }
        public string TipoDocuClie { get; set; }
        public string ClienteRuc { get; set; }
        public string ClienteNombre { get; set; }
        public decimal? ValorVenta { get; set; }
        public int ValorInafecta { get; set; }
        public int Isc { get; set; }
        public decimal Igv { get; set; }
        public int OtroTributo { get; set; }
        public decimal? Total { get; set; }
        public string TipoDocuModi { get; set; }
        public string SerieDocuModi { get; set; }
        public string NumeDocuModi { get; set; }
    }
}
