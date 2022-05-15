using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeStockProducto
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public int? IdProducto { get; set; }
        public decimal? CantidadInicial { get; set; }
        public decimal? CantidadIngresada { get; set; }
        public decimal? CantidadSalida { get; set; }
        public decimal? CantidadActual { get; set; }
    }
}
