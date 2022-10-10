using System.Collections.Generic;

namespace PLANTILLA_API_ODATA.Models.DTO.Pedido
{
    public class ComandaDTO
    {
        public string NUMERO_PEDIDO { get; set; }
        public string DESTINO { get; set; }
        public string ZONA { get; set; }
        public string MESA { get; set; }
        public string MESERO { get; set; }
        public string RUTACOMANDA { get; set; }
        public string FECHAYHORA { get; set; }
        public IList<DetalleComandarDTO> Detalle { get; set; }
    }
}
