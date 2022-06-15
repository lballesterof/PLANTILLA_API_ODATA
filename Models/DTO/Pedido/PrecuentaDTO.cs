using System.Collections.Generic;

namespace PLANTILLA_API_ODATA.Models.DTO.Pedido
{
    public class PrecuentaDTO
    {
        public string NUMERO_PEDIDO { get; set; }
        public string ZONA { get; set; }
        public string MESA { get; set; }
        public string MESERO { get; set; }
        public string OBSERVACIONES { get; set; }
        public string FECHAYHORA { get; set; }

        public virtual IList<DetalleprecuentaDTO> detalle { get; set; }
    }

}
