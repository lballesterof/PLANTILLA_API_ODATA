using AutoMapper;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.DetalleTabla;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services
{
    public class OpeTablaServices : IOpeTablaServices
    {

        private DataContext db;

        private readonly IMapper _mapper;

        public OpeTablaServices(DataContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }
        public IQueryable<OpeTabla> RetrieveAllTablas()
        {
            List<OpeTabla> _List = db.OpeTablas.ToList();
            IQueryable<OpeTabla> retrievedTablas= _List.AsQueryable();
            return retrievedTablas;
        }
        public IQueryable<OpeDetalleTabla> RetrieveAllDetailTablas()
        {
            //_context = new DataContext();
            List<OpeDetalleTabla> _List = db.OpeDetalleTablas.ToList();
            IQueryable<OpeDetalleTabla> retrievedTablas = _List.AsQueryable();
            return retrievedTablas;
        }
    }
}
