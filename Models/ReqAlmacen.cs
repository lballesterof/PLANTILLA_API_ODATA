using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class ReqAlmacen
    {
        public string ReqId { get; set; }
        public decimal CoocId { get; set; }
        public decimal IdGuia { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SecuenciaReq { get; set; }
        public decimal SecuenciaOc { get; set; }
        public decimal SecuenciaGuia { get; set; }
    }
}
