using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwDpstockCcc
    {
        public string CodigoSucursal { get; set; }
        public string TipoGuia { get; set; }
        public decimal IdProducto { get; set; }
        public string CdgCaja { get; set; }
        public string CdgColumna { get; set; }
        public string CdgCasillero { get; set; }
        public decimal? Ingreso { get; set; }
        public decimal? Salida { get; set; }
        public decimal? IdProveedor { get; set; }
    }
}
