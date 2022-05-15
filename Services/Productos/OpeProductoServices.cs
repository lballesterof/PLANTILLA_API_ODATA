using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Productos
{
    public class OpeProductoServices : IOpePersonaServices
    {


        private readonly DataContext _context;

        public OpeProductoServices()
        {
            _context = new DataContext();
        }


        public IQueryable<OpeProducto> RetrieveAllProductos()
        {
            //_context = new DataContext();
            List<OpeProducto> _List = _context.OpeProductos.ToList();
            IQueryable<OpeProducto> retrievedProductos = _List.AsQueryable();
            return retrievedProductos;
        }

    }
}
