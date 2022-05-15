using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwObtenerDocumento
    {
        public decimal IdDocumento { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? PrecioCompra { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Modulo { get; set; }
    }
}
