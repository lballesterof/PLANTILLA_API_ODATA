using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwSalInvPorMovCc
    {
        public string CodigoEmpresa { get; set; }
        public string Almacen { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public decimal? Stock { get; set; }
        public string CdgCc { get; set; }
        public string CentroCosto { get; set; }
        public string SubCentroCosto { get; set; }
    }
}
