using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleDocumentoCompra2
    {
        public int IdDocumento { get; set; }
        public string RucPrv { get; set; }
        public string NumDocu { get; set; }
        public string CdgTdoc { get; set; }
        public int? IdOc { get; set; }
        public int? IdProducto { get; set; }
        public string DescripcionProd { get; set; }
        public decimal? CanDfac { get; set; }
        public decimal? PreDfac { get; set; }
        public decimal? DctDfac { get; set; }
        public decimal? ImpDfac { get; set; }
        public string Cuenta { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Importe { get; set; }
        public string Afina { get; set; }
        public string CdgTana { get; set; }
        public string CdgAnal { get; set; }
        public string TipProv { get; set; }
        public string NumPoli { get; set; }
        public string BasPor { get; set; }
        public string EstPoli { get; set; }
        public decimal NumSec { get; set; }
        public string OrdProd { get; set; }
        public string OrdServ { get; set; }
        public decimal? ValValor { get; set; }
        public string CdgProd { get; set; }
        public string CdgCc { get; set; }
        public string CdgGasto { get; set; }
        public string CdgUnidad { get; set; }
        public decimal? IdGuia { get; set; }
        public string PrecioIgv { get; set; }
        public string CodigoAlmacen { get; set; }
        public string ScdgCc { get; set; }
        public decimal? PrecioAjuste { get; set; }
        public decimal? ImporteAjuste { get; set; }
        public decimal? PrecioOtro { get; set; }
        public decimal? ImporteOtro { get; set; }
        public decimal? ItemPf { get; set; }
        public decimal? PreSigv { get; set; }
        public decimal? PreInv { get; set; }
        public decimal? FactorConversion { get; set; }
    }
}
