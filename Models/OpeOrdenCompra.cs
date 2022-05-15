using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOrdenCompra
    {
        public int IdOc { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPersona { get; set; }
        public string FormaPago { get; set; }
        public string Moneda { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal Importe { get; set; }
        public decimal PorcentajeDscto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Igv { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public string LugarEntrega { get; set; }
        public string Observacion { get; set; }
        public string CdgCoti { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CodigoEmpresa { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string UsuarioAutoriza { get; set; }
        public string Atencion { get; set; }
        public string Referencia { get; set; }
        public string Incoterms { get; set; }
        public string ShipOrder { get; set; }
        public string ShippingMarks { get; set; }
        public string ShipTo { get; set; }
        public string BillNetPriceTo { get; set; }
        public string Responsable { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal? PorcentajeIgv { get; set; }
        public decimal? ValorCompra { get; set; }
        public string TipoDocu { get; set; }
        public string MedioTransporte { get; set; }
        public string PagoAdelantado { get; set; }
        public DateTime? FechaEstimadaEmbarque { get; set; }
        public DateTime? FechaEstimadaLlegada { get; set; }
        public string OrdenPedido { get; set; }
        public string MotiOrco { get; set; }
        public string SwtIgv { get; set; }
        public string Almacen { get; set; }
        public decimal? TipoCambio { get; set; }
        public string RefNum { get; set; }
        public string EntregaMaterial { get; set; }
        public string EntregaFactura { get; set; }
        public string Num { get; set; }
        public decimal? Flete { get; set; }
        public decimal? ValorAfecto { get; set; }
        public decimal? ValorInafecto { get; set; }
        public string Requi { get; set; }
    }
}
