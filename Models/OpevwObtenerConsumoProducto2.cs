using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwObtenerConsumoProducto2
    {
        public string Trab2 { get; set; }
        public string Codigo { get; set; }
        public string FechaRegistro { get; set; }
        public string Categoria { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroSerie { get; set; }
        public string Producto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal? SubTotalSoles { get; set; }
        public decimal? SubTotalDolar { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public string CondicionPago { get; set; }
        public string IdTipoProducto { get; set; }
        public string IdCategoria { get; set; }
        public decimal IdProducto { get; set; }
    }
}
