using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetallePartidaPresupuesto
    {
        public decimal IdPresupuesto { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdItem { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Horas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public decimal Secuencia { get; set; }
        public string Tipo { get; set; }
        public decimal? SecProd { get; set; }
        public decimal? PrecioUnitarioOri { get; set; }
    }
}
