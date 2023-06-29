using AutoMapper;
using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.MapperProfiles
{   
    public class FileProfiles :Profile
    {
        public FileProfiles()
        {
            CreateMap<FileCreateDto, Entity.File>()
                .ForMember(dest => dest.FileType, opt =>
                opt.MapFrom(src => Enum.Parse(typeof(FileType), src.FileType, true)));
        }
    }
}
