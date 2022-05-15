using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeTempComandum
    {
        public decimal IdPedido { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Secuencia { get; set; }
        public string Zona { get; set; }
        public string Mesa { get; set; }
        public string Mozo { get; set; }
        public string Caja { get; set; }
        public string Turno { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public string Estado { get; set; }
    }
}
