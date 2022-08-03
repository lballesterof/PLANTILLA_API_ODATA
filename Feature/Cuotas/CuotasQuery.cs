using MediatR;
using PLANTILLA_API_ODATA.Interfaces;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Specifications.Cuotas;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PLANTILLA_API_ODATA.Feature.Cuotas
{
    public class CuotasQuery : IRequest<List<VwMbGetCuotasInmobiliarium>>
    {
        public string Ruc { get; set; }
        public int? Año { get; set; }

        public class CuotasQueryHandler : IRequestHandler<CuotasQuery, List<VwMbGetCuotasInmobiliarium>>
        {
            private readonly IRepositoryAsync<VwMbGetCuotasInmobiliarium> _repositoryAsync;

            public CuotasQueryHandler(IRepositoryAsync<VwMbGetCuotasInmobiliarium> repositoryAsync)
            {
                _repositoryAsync = repositoryAsync;
            }

            public async Task<List<VwMbGetCuotasInmobiliarium>> Handle(CuotasQuery request, CancellationToken cancellationToken)
            {
                var listadostocks = await _repositoryAsync.ListAsync(new PagedCuotasSpecification(request.Ruc, request.Año.ToString()));
                return new List<VwMbGetCuotasInmobiliarium>(listadostocks);
            }
        }



    }
}
