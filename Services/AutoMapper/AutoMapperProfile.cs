using AutoMapper;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.DetalleTabla;
using PLANTILLA_API_ODATA.Models.DTO.Users;

namespace PLANTILLA_API_ODATA.Services.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<OpeUsuarioDTO,OpeUsuario>().ReverseMap();
            CreateMap<OpeDetalleTablaDTO, OpeDetalleTabla>().ReverseMap();
        }
    }
}
