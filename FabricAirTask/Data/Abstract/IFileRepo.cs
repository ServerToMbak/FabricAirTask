using FabricAirTask.Entity;

namespace FabricAirTask.Data.Abstract
{
    public interface IFileRepo
    {
        public Task<Entity.File> Add(Entity.File file);
        public Task<Entity.File> Update(int id, Entity.File file);
        public Task Delete(int id);
        public Task<Entity.File> GetById(int id);
        public Task<List<Entity.File>> GetAll();
        public Task<List<Entity.File>> GetFilesByUserName(string name);
        public Task<List<Entity.File>> GetFilesByUserId(int userId);
        public Task<List<Entity.File>> GetFilesByUserIdAndByFileType(FileType fileType, int userId);

    }
}
