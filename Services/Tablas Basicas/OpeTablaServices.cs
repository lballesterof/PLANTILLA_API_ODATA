using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services
{
    public class OpeTablaServices : IOpeTablaServices
    {
        private readonly DataContext _context;

        public OpeTablaServices()
        {
            _context = new DataContext();
        }


        public IQueryable<OpeTabla> RetrieveAllTablas()
        {
           //_context = new DataContext();
            List<OpeTabla> _List = _context.OpeTablas.ToList();
            IQueryable<OpeTabla> retrievedTablas= _List.AsQueryable();
            return retrievedTablas;
        }
        public IQueryable<OpeDetalleTabla> RetrieveAllDetailTablas()
        {
            //_context = new DataContext();
            List<OpeDetalleTabla> _List = _context.OpeDetalleTablas.ToList();
            IQueryable<OpeDetalleTabla> retrievedTablas = _List.AsQueryable();
            return retrievedTablas;
        }
    }
}
