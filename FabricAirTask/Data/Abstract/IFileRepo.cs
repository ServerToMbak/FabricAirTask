using FabricAirTask.Entity;

namespace FabricAirTask.Data.Abstract
{
    public interface IFileRepo
    {
        public Task<Entity.File> Add(Entity.File file);

        public Task<List<Entity.File>> GetAll();
        public Task<Entity.File> Update(Entity.File file);
        public Task<List<Entity.File>> GetFilesByUserName(string name);
        public Task<List<Entity.File>> GetFilesByUserId(int userId);
        public Task<List<Entity.File>> GetFilesByUserIdAndByFileType(FileType fileType, int userId);

    }
}
