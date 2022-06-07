using AutoMapper;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using Spring.Objects.Factory.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace PLANTILLA_API_ODATA.Services.Usuario
{
    public class OpeUsuarioService:IOpeUsuarioService
    {


        private DataContext db;
        private readonly IMapper _mapper;


        public OpeUsuarioService(DataContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }
       

        public IQueryable<OpeUsuario> RetrieveAllUsers()
        {
            //_context = new DataContext();
           List<OpeUsuario>_List =db.OpeUsuarios.ToList();
            IQueryable<OpeUsuario> retrievedUsers = _List.AsQueryable();
            return retrievedUsers;
        }
    }
}
