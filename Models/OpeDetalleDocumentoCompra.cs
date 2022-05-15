using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleDocumentoCompra
    {
        public decimal IdDetallle { get; set; }
        public decimal IdDocumento { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? Importe { get; set; }
        public decimal? IgvPorcentaje { get; set; }
        public decimal? Igv { get; set; }
        public decimal? DescuentoPorcentaje { get; set; }
        public decimal? Descuento { get; set; }
        public string DescripcionExtendida { get; set; }
        public string IdSucursal { get; set; }
        public int Secuencia { get; set; }
        public decimal? CantidadInout { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Costo { get; set; }
        public string CodigoUnidad { get; set; }
        public decimal? Costof { get; set; }
        public decimal? Costol { get; set; }
        public string CdgProd { get; set; }
        public decimal? Costod { get; set; }
        public decimal? PrecioComprad { get; set; }
        public string UnidadEqui { get; set; }
        public decimal? Factor { get; set; }
        public int? SecReq { get; set; }
        public string Req { get; set; }
        public decimal? IdOc { get; set; }
        public string Comentario { get; set; }
        public string SwtImp { get; set; }
        public decimal? IdReceta { get; set; }
        public decimal? SecReceta { get; set; }
        public string ScdgCc { get; set; }
        public string CdgCc { get; set; }
        public string CdgZona { get; set; }
        public string Fila { get; set; }
        public string Columna { get; set; }

        public virtual OpeDocumentoCompra IdDocumentoNavigation { get; set; }
        public virtual OpeProducto IdProductoNavigation { get; set; }
    }
}
