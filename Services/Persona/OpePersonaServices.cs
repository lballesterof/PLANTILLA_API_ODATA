using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Persona
{
    public class OpePersonaServices : IOpePersonaServices
    {


        private readonly DataContext _context;

        public OpePersonaServices(DataContext context)
        {
            _context = context;
        }



        IQueryable<OpePersona> IOpePersonaServices.RetrieveAllProductos()
        {
            //_context = new DataContext();
            List<OpePersona> _List = _context.OpePersonas.ToList();
            IQueryable<OpePersona> retrievedProductos = _List.AsQueryable();
            return retrievedProductos;
        }
    }
}
