namespace FabricAirTask.Data.Abstract
{
    public interface IFileRepo
    {
        public Entity.File Add(Entity.File file);

        public List<Entity.File> GetAll();
        public Entity.File Update(Entity.File file);
        public List<Entity.File> GetFilesByUserName(string name);
        public List<Entity.File> GetFilesByUserId(int userId);

    }
}
