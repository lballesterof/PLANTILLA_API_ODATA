using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpePromocionProducto
    {
        public decimal IdPromocion { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PrecioVenta { get; set; }
        public string CodigoKit { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
