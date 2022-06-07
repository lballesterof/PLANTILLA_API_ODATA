using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Pedido;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Pedido
{
    public interface IOpePedidoService
    {
        IQueryable<OpePedido> RetrieveAllPedidos();
        CabeceraPedidoDTO SavePedido(CabeceraPedidoDTO pedido);

    }
}
