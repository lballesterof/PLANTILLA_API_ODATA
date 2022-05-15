using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOfprProducto
    {
        public string CodigoEmpresa { get; set; }
        public string Codigo { get; set; }
        public decimal IdProducto { get; set; }
        public string IdTipoCliente { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Descuento1 { get; set; }
        public decimal Descuento2 { get; set; }
        public decimal? Cantidad2 { get; set; }
        public decimal? Cantidad3 { get; set; }
        public decimal? Cantidad4 { get; set; }
        public decimal? Descuento3 { get; set; }
        public decimal? Descuento4 { get; set; }
    }
}
