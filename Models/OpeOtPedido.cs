using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class OpeOtPedido
    {
        public string CdgOp { get; set; }
        public string CdgOs { get; set; }
        public string CdgOt { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
    }
}
