using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwProductoMasVendidoMonto
    {
        public DateTime FechaRegistro { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? SubTotal { get; set; }
        public string Moneda { get; set; }
        public string Mesa { get; set; }
        public string Mozo { get; set; }
    }
}
