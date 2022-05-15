using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwReqOcCc
    {
        public DateTime DdFechaOc { get; set; }
        public string NumeroPedido { get; set; }
        public string Cliente { get; set; }
        public string MonOp { get; set; }
        public decimal? TotalOp { get; set; }
        public string Sucursal { get; set; }
        public string OrdenCompra { get; set; }
        public string Proveedor { get; set; }
        public string MonOc { get; set; }
        public decimal TotalOc { get; set; }
        public string Responsable { get; set; }
        public string NroCheque { get; set; }
        public string IngAlmacen { get; set; }
        public string EstadoOc { get; set; }
    }
}
