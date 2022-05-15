using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleOrdenCompra
    {
        public int IdProducto { get; set; }
        public int IdOc { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Afecto { get; set; }
        public int Secuencia { get; set; }
        public decimal Importe { get; set; }
        public decimal CantidadIngresada { get; set; }
        public decimal CantidadFacturada { get; set; }
        public string CodigoUnidad { get; set; }
        public string DescripcionExtendida { get; set; }
        public decimal? Dscto { get; set; }
        public decimal? PrecioOri { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int? SecReq { get; set; }
        public string Req { get; set; }
        public string Ai { get; set; }
        public string CdgCc { get; set; }
        public decimal? PorDetraccion { get; set; }
        public decimal? Detraccion { get; set; }
        public decimal? FactorConversion { get; set; }
        public string ScdgCc { get; set; }
        public decimal? IdReq { get; set; }
    }
}
