using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleGuia3
    {
        public decimal IdProducto { get; set; }
        public decimal IdDocumento { get; set; }
        public decimal? IdProveedor { get; set; }
        public string CodigoSucursal { get; set; }
        public string CdgUnidad { get; set; }
        public decimal Factor { get; set; }
        public string CdgUnidadEqui { get; set; }
        public decimal Cantidad { get; set; }
        public string CdgCaja { get; set; }
        public string CdgColumna { get; set; }
        public string CdgCasillero { get; set; }
        public string CdgMarca { get; set; }
        public string CdgModelo { get; set; }
        public decimal? Secuencia { get; set; }
    }
}
