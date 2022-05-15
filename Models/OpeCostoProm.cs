using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeCostoProm
    {
        public string CodigoSucursal { get; set; }
        public int IdProducto { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public decimal Costo { get; set; }
        public decimal Saldo { get; set; }
        public decimal? Costof { get; set; }
        public decimal? Costol { get; set; }
    }
}
