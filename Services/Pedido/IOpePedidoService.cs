using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Pedido;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Pedido
{
    public interface IOpePedidoService
    {
        IQueryable<OpePedido> RetrieveAllPedidos();
        OpePedido PedidoWithDetail(string idPedido);
        CabeceraPedidoDTO SavePedido(CabeceraPedidoDTO pedido);
        public PrecuentaDTO PrecuentafinbyId(string idPedido);
        public List<ComandaDTO> ComandarfinbyIdAndComanda(string idPedido);
    }
}
