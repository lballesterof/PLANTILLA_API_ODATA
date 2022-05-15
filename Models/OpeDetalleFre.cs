using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleFre
    {
        public string NumeroFre { get; set; }
        public string Serie { get; set; }
        public string SerieGenerada { get; set; }
        public string CdgEstado { get; set; }
        public int IdEquipo { get; set; }
        public string CdgMarca { get; set; }
        public string CdgModelo { get; set; }
        public string Observacion { get; set; }
        public int Secuencia { get; set; }
        public DateTime FechaGenerada { get; set; }
        public string SwtCxg { get; set; }
        public string SwtTb { get; set; }
        public decimal? Kilometraje { get; set; }
        public string CdgColor { get; set; }
    }
}
