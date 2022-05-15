using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeValorizacion
    {
        public decimal IdProducto { get; set; }
        public string CodigoSucursal { get; set; }
        public decimal Ano { get; set; }
        public decimal Mes { get; set; }
        public decimal CostoSol { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal? CostoDol { get; set; }
    }
}
