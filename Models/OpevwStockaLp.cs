using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwStockaLp
    {
        public string CodigoEmpresa { get; set; }
        public string NomAlmacen { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
    }
}
