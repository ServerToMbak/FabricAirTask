using FabricAirTask.Data;

namespace FabricAirTask.Services
{
    public class FileService : IFileService
    {
        private IFileRepo _fileRepo;

        public FileService(IFileRepo fileRepo)
        {
            _fileRepo = fileRepo;
        }
        public Entity.File AddFile(Entity.File file)
        {
           return _fileRepo.Add(file);
           
        }

        public List<Entity.File> GetAll()
        {
            return _fileRepo.getAll();
        }
    }
}
