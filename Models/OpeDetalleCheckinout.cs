using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleCheckinout
    {
        public decimal IdCheckinout { get; set; }
        public string IdHabitacion { get; set; }
        public string IdConcepto { get; set; }
        public decimal Unidad { get; set; }
        public decimal Dias { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public decimal Dscto { get; set; }
        public decimal Importe { get; set; }
        public string Tipo { get; set; }
        public string SwtFact { get; set; }
        public decimal? Secuencia { get; set; }
        public string Suplemento { get; set; }
        public string SwtAuto { get; set; }
        public decimal? IdProducto { get; set; }
        public decimal? IdPedido { get; set; }
    }
}
