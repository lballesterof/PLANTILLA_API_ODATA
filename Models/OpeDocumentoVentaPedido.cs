using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeDocumentoVentaPedido
    {
        public decimal? IdDocumento { get; set; }
        public decimal? IdPedido { get; set; }
        public decimal? IdGuia { get; set; }
        public decimal? IdProducto { get; set; }
        public int? Secuencia { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
