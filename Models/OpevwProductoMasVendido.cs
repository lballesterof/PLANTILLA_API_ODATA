using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpevwProductoMasVendido
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoSucursal { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string Categoria { get; set; }
        public decimal IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
