using Ardalis.Specification;
using PLANTILLA_API_ODATA.Models;

namespace PLANTILLA_API_ODATA.Specifications.Cuotas
{
    public class PagedCuotasSpecification : Specification<VwMbGetCuotasInmobiliarium>
    {
        public PagedCuotasSpecification(string ruc, string año)
        {
        //    Query.Skip((pageNumber - 1) * pageSize)
        //.Take(pageSize);

            if (!string.IsNullOrEmpty(año))
            {
                Query.Search(x => x.Año.ToString(), año).Where(x=> x.Ruc.Equals(ruc)) ;
               
            }
            else
            {
                Query.Search(x => x.Ruc, ruc);
            }
            Query.OrderBy(x => x.Cuota);
        }
    }
}
