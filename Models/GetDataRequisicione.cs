using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class GetDataRequisicione
    {
        public string NumGasto { get; set; }
        public string TipoConcepto { get; set; }
        public string Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string CentroCosto { get; set; }
        public string Persona { get; set; }
        public string Concepto { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Moneda { get; set; }
        public string Afecto { get; set; }
        public string IncluyeIgv { get; set; }
        public decimal? PrecioSoles { get; set; }
        public decimal? SubtotalSoles { get; set; }
        public decimal? IgvSoles { get; set; }
        public decimal? ImpSoles { get; set; }
        public decimal? PrecioDolar { get; set; }
        public decimal? SubtotalDolar { get; set; }
        public decimal? IgvDolar { get; set; }
        public decimal? ImpDolar { get; set; }
        public string Observacion { get; set; }
        public int? Imes { get; set; }
        public string EstadoPago { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? TotalDolar { get; set; }
        public decimal? TotalSoles { get; set; }
        public decimal? StotalDolar { get; set; }
        public decimal? StotalSoles { get; set; }
        public decimal IdProducto { get; set; }
    }
}
