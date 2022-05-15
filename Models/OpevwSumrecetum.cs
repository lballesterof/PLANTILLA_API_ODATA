using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwSumrecetum
    {
        public DateTime? FechaApertura { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal? IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
