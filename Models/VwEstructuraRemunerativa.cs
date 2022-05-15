using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwEstructuraRemunerativa
    {
        public string NumeroDocumento { get; set; }
        public string Trabajador { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string CdgCc { get; set; }
        public decimal? Remuneracion { get; set; }
        public decimal? Vaca { get; set; }
        public decimal? Grati { get; set; }
        public decimal? Cts { get; set; }
        public int ProvAporta { get; set; }
    }
}
