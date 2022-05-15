using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwVentaRentabilidadce
    {
        public decimal IdProducto { get; set; }
        public string TipoProd { get; set; }
        public string Categoria { get; set; }
        public string Grupo { get; set; }
        public string Subgrupo { get; set; }
        public string CdgOp { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Moneda { get; set; }
        public string Mon { get; set; }
        public int IdPersona { get; set; }
        public string Cliente { get; set; }
        public string IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string IdMarca { get; set; }
        public string Marca { get; set; }
        public string IdModelo { get; set; }
        public string Modelo { get; set; }
        public decimal? PrecioS { get; set; }
        public decimal? PrecioD { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? ValorVentaSinNcS { get; set; }
        public decimal? ValorVentaSinNcD { get; set; }
        public decimal? ValorVentaConNcS { get; set; }
        public decimal? ValorVentaConNcD { get; set; }
        public decimal CostopromSoles { get; set; }
        public decimal CostopromDolar { get; set; }
        public decimal CostotSoles { get; set; }
        public decimal CostotDolar { get; set; }
        public decimal? MargenSoles { get; set; }
        public decimal? MargenDolar { get; set; }
        public decimal? PorMargen { get; set; }
        public string IdTipoProducto { get; set; }
        public string IdCategoria { get; set; }
        public string IdGrupo { get; set; }
        public string IdSubgrupo { get; set; }
        public decimal IdDocumento { get; set; }
        public string Refvend { get; set; }
        public string Vendedor { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string Trimestre { get; set; }
        public string Semestre { get; set; }
    }
}
