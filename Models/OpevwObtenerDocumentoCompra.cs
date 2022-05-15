using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwObtenerDocumentoCompra
    {
        public decimal? CantidadInout { get; set; }
        public decimal? PrecioCompra { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal IdProducto { get; set; }
        public string CodigoSucursal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
