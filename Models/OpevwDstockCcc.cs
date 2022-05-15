using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDstockCcc
    {
        public string CodigoSucursal { get; set; }
        public decimal IdProducto { get; set; }
        public decimal? StkIng { get; set; }
        public decimal? StkSal { get; set; }
        public decimal? StkAct { get; set; }
        public decimal? IdProveedor { get; set; }
        public string CdgCaja { get; set; }
        public string CdgColumna { get; set; }
        public string CdgCasillero { get; set; }
    }
}
