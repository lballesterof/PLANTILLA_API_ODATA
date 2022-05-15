using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwVentaExportar
    {
        public DateTime DdFechaEmision { get; set; }
        public decimal IdDocumento { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Moneda { get; set; }
        public string CondicionPago { get; set; }
        public string Vendedor { get; set; }
        public string Reftdoc { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroSerie { get; set; }
        public string NumeroMaquina { get; set; }
        public string TextoImporte { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal PorIgv { get; set; }
        public decimal? Total { get; set; }
        public decimal Igv { get; set; }
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? PrecioOriginal { get; set; }
        public decimal SubTotalitem { get; set; }
        public decimal? Igvitem { get; set; }
        public decimal? PorIgvitem { get; set; }
        public string SwtPigv { get; set; }
        public string Tipo { get; set; }
        public string TipoAfecIgv { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Abono { get; set; }
        public decimal Vuelto { get; set; }
        public string Turno { get; set; }
        public decimal? Descuento { get; set; }
        public string Observacion { get; set; }
        public decimal? TipoCambio { get; set; }
        public int Secuencia { get; set; }
    }
}
