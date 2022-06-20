using Microsoft.AspNetCore.Mvc;
using PLANTILLA_API_ODATA.Models;
using System.Linq;
using System.Web.Mvc;

namespace PLANTILLA_API_ODATA.Services.Mesas
{
    public interface IOpeMesaService
    {
        IQueryable<OpeMesa> RetrieveAllMesas();
  


    }
}
