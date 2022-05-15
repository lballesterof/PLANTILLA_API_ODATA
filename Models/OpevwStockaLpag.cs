using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwStockaLpag
    {
        public string CodigoEmpresa { get; set; }
        public string NomAlmacen { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Stock { get; set; }
    }
}
