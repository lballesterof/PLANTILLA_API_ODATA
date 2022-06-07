using AutoMapper;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using Spring.Objects.Factory.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Mesas
{
    public class OpeMesaService: IOpeMesaService
    {


        private DataContext db;
        public OpeMesaService(DataContext context)
        {
            db = context;
        }


        IQueryable<OpeMesa> IOpeMesaService.RetrieveAllMesas()
        {
            List<OpeMesa> _List = db.OpeMesas.ToList();
            IQueryable<OpeMesa> retrievedUsers = _List.AsQueryable();
            return retrievedUsers;
        }
    }
}
