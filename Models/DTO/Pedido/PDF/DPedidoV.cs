using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Models.DTO.Pedido.PDF
{
    public class DPedidoV
    {
        public long ID_PEDIDO { get; set; }
        public long ID_PRODUCTO { get; set; }
        public long CANTIDAD { get; set; }

        public string CODIGO_BARRA { get; set; }
        public string NOMBRE { get; set; }
        public string UNIDAD { get; set; }
        public decimal PRECIO { get; set; }

        public decimal IMPORTE { get; set; }

        public decimal IGV { get; set; }
        public long SECUENCIA { get; set; }


    }
}
