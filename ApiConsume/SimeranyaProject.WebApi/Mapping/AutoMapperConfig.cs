using AutoMapper;
using Simeranya.Dto.Dtos.RoomDto;
using Simeranya.EntityLayer.Concreate;

namespace SimeranyaProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    { //DTO sınıfı propertiler ile entity katmanında yer alan sınıflardaki propertiler eşleşir
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
