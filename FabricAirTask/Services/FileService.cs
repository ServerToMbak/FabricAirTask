using AutoMapper;
using FabricAirTask.Data;
using FabricAirTask.Dto;

namespace FabricAirTask.Services
{
    public class FileService : IFileService
    {
        private IFileRepo _fileRepo;
        private IMapper _mapper;

        public FileService(IFileRepo fileRepo, IMapper mapper)
        {
            _fileRepo = fileRepo;
            _mapper =  mapper;
        }
        public Entity.File AddFile(FileCreateDto fileCreateDto)
        {
           var file = _mapper.Map<Entity.File>(fileCreateDto);
           return _fileRepo.Add(file);
           
        }

        public List<Entity.File> GetAll()
        {
            return _fileRepo.GetAll();
        }

        public List<Entity.File> GetAllFilesByUserName(string userName)
        {
            throw new NotImplementedException();
        }

      
    }
}
