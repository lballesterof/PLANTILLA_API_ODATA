using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwSalInvPorMov
    {
        public string CodigoEmpresa { get; set; }
        public string Almacen { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public decimal? Ingreso2 { get; set; }
        public decimal? Salida2 { get; set; }
    }
}
