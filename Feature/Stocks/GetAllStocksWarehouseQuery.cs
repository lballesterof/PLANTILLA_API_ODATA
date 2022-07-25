using MediatR;
using PLANTILLA_API_ODATA.Interfaces;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Specifications.Stocks;
using PLANTILLA_API_ODATA.Wrappers;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Feature.Stocks
{
    public class GetAllStocksWarehouseQuery: IRequest<List<VwGetstockAllwarehousePricelist>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string CdgRef { get; set; }
        public string Nombre { get; set; }
        public class GetAllStocksWarehouseQueryHandler : IRequestHandler<GetAllStocksWarehouseQuery, List<VwGetstockAllwarehousePricelist>>
        {
            private readonly IRepositoryAsync<VwGetstockAllwarehousePricelist> _repositoryAsync;

            public GetAllStocksWarehouseQueryHandler(IRepositoryAsync<VwGetstockAllwarehousePricelist> repositoryAsync)
            {
                _repositoryAsync = repositoryAsync;
            }
            public async Task<List<VwGetstockAllwarehousePricelist>> Handle(GetAllStocksWarehouseQuery request, CancellationToken cancellationToken)
            {
                  var  listadostocks = await _repositoryAsync.ListAsync(new PagedStocksWarehouseSpecification(request.PageSize, request.PageNumber, request.CodigoBarra, request.Codigo,request.CdgRef, request.Nombre));
                  return new List<VwGetstockAllwarehousePricelist>(listadostocks);
            }
        }
    }
}
