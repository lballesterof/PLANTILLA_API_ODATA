using Ardalis.Specification;
using PLANTILLA_API_ODATA.Models;

namespace PLANTILLA_API_ODATA.Specifications.Stocks
{
    public class PagedStocksWarehouseSpecification : Specification<VwGetstockAllwarehousePricelist>
    {
        public PagedStocksWarehouseSpecification(int pageSize, int pageNumber, string codbarra, string codigo, string codreferencia, string nombre)
        {
            Query.Skip((pageNumber - 1) * pageSize)
        .Take(pageSize);

            if (!string.IsNullOrEmpty(nombre))
                Query.Search(x => x.Nombre, "%" + nombre + "%");

            if (!string.IsNullOrEmpty(codbarra))
                Query.Search(x => x.CodigoBarra, "%" + codbarra + "%");

            if (!string.IsNullOrEmpty(codigo))
                Query.Search(x => x.Codigo, "%" + codigo + "%");

            if (!string.IsNullOrEmpty(codreferencia))
                Query.Search(x => x.CdgRef, "%" + codreferencia + "%");
        }
    }
}
