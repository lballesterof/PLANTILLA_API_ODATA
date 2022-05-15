using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwObtenerRegistroVentum
    {
        public decimal NumOperacion { get; set; }
        public DateTime DdFechaDocu { get; set; }
        public string TipoDocu { get; set; }
        public string Numero { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string TipoProducto { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Grupo { get; set; }
        public string SubGrupo { get; set; }
        public string CondicionPago { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string CodigoPedido { get; set; }
        public string Nombre { get; set; }
        public decimal? PrecioLista { get; set; }
        public decimal? PorDscto { get; set; }
        public decimal? ImporteDscto { get; set; }
        public decimal? PrecioConDscto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? ImporteItem { get; set; }
        public decimal? ImporteItemConDscto { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? ValorVenta { get; set; }
        public decimal Igv { get; set; }
        public decimal? Total { get; set; }
        public decimal? MontoDolar { get; set; }
        public decimal? Tc { get; set; }
        public string Referencia { get; set; }
        public string Almacen { get; set; }
        public string TipoRegistro { get; set; }
    }
}
