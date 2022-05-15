using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDetalleDocumentoVentum
    {
        public decimal IdDetallle { get; set; }
        public decimal IdDocumento { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal MontoEmpresa { get; set; }
        public decimal MontoTrabajador { get; set; }
        public decimal SubTotal { get; set; }
        public int Secuencia { get; set; }
        public string NumeroComanda { get; set; }
        public string Comentario { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public decimal? Costo { get; set; }
        public string Tipo { get; set; }
        public decimal? Dscto { get; set; }
        public decimal? ImporteDscto { get; set; }
        public decimal? PrecioOriginal { get; set; }
        public decimal? Igv { get; set; }
        public string CdgProd { get; set; }
        public decimal? Comision { get; set; }
        public decimal? Margen { get; set; }
        public decimal? ImporteMargen { get; set; }
        public decimal? IdPedido { get; set; }
        public decimal? IdDocu { get; set; }
        public string TipoLista { get; set; }
        public decimal? IdProductoParent { get; set; }
        public string Unidad { get; set; }
        public decimal? PorPercepcion { get; set; }
        public decimal? Percepcion { get; set; }
        public string Os { get; set; }
        public string FlagAdd { get; set; }
        public decimal? ValorVen { get; set; }
        public string UnidVen { get; set; }
        public DateTime? FechaVen { get; set; }
        public string CdgKit { get; set; }
        public string SwtPigv { get; set; }
        public string SwtProm { get; set; }
        public string SwtImp { get; set; }
        public decimal? CantKit { get; set; }
        public string SwtDcom { get; set; }
        public string SwtFree { get; set; }
        public string NomImp { get; set; }
        public decimal? SecProd { get; set; }
        public string TipoAfecIgv { get; set; }
        public string CdgTipoDetr { get; set; }
        public string GrupTipoAfecIgv { get; set; }
        public decimal? PorDetraccion { get; set; }
        public decimal? Detraccion { get; set; }
        public string Referencia1 { get; set; }
        public decimal? PorIgv { get; set; }
        public decimal? Vv { get; set; }
        public string CdgVend { get; set; }

        public virtual OpeDocumentoVentum IdDocumentoNavigation { get; set; }
    }
}
