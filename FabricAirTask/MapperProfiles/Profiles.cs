using AutoMapper;
using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.MapperProfiles
{   
    public class Profiles :Profile
    {
        public Profiles()
        {
            CreateMap<FileCreateDto, Entity.File>()
                .ForMember(dest => dest.FileType, opt =>
                opt.MapFrom(src => Enum.Parse(typeof(FileType), src.FileType, true)));

            CreateMap<Entity.File, FileReadDto>()
            .ForMember(dest => dest.FileType, opt => opt.MapFrom(src => src.FileType.ToString()));



            CreateMap<User, UserDto>();


        }
    }
}
