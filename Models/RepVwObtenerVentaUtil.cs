using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RepVwObtenerVentaUtil
    {
        public DateTime DdFechaDocu { get; set; }
        public string TipoDocu { get; set; }
        public string Numero { get; set; }
        public string CondicionPago { get; set; }
        public string Ruc { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string CdgProd { get; set; }
        public string Producto { get; set; }
        public string Grupo { get; set; }
        public string SubGrupo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? PrecioUnit { get; set; }
        public decimal? TotalVenta { get; set; }
        public decimal? TotalVentaSinIgv { get; set; }
        public decimal? CostoUnit { get; set; }
        public decimal? CostoTotal { get; set; }
        public decimal? UtilidadBrutaSinIgv { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Tc { get; set; }
        public string Almacen { get; set; }
    }
}
