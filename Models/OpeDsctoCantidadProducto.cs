using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDsctoCantidadProducto
    {
        public string CdgListaPrecio { get; set; }
        public decimal IdProducto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Dscto { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioDscto { get; set; }
        public string Moneda { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Secuencia { get; set; }
        public string Tipo { get; set; }
        public string AutoP { get; set; }
        public string Unidad { get; set; }
        public decimal FactorConversion { get; set; }
    }
}
