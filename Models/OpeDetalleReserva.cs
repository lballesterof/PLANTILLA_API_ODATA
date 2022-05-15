using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleReserva
    {
        public decimal IdReserva { get; set; }
        public string IdConcepto { get; set; }
        public decimal Unidad { get; set; }
        public decimal Dias { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Precio { get; set; }
        public decimal Dscto { get; set; }
        public string Tipo { get; set; }
        public decimal? Secuencia { get; set; }
        public string Suplemento { get; set; }
        public string SwtAuto { get; set; }
    }
}
