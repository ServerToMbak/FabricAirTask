using FabricAirTask.Dto;

namespace FabricAirTask.Services
{
    public interface IFileService
    {
        public Entity.File AddFile(FileCreateDto file);
        public List<Entity.File> GetAll();
    }
}
