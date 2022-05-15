using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class BiListaPedido
    {
        public string IdVendedor { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string Vendedor { get; set; }
        public string Estado { get; set; }
        public DateTime FechaDocu { get; set; }
        public string Pedido { get; set; }
        public string Motivo { get; set; }
        public string Coti { get; set; }
        public string Simbolo { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal Igv { get; set; }
        public decimal Total { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? VentaRealNetaUsd { get; set; }
        public int Al30 { get; set; }
        public int Al50 { get; set; }
        public int Al80 { get; set; }
        public string CondicionPago { get; set; }
        public string Cliente { get; set; }
        public string Recibido { get; set; }
        public string CdgEstado { get; set; }
        public string CdgMotivo { get; set; }
        public string CdgCondicionPago { get; set; }
    }
}
