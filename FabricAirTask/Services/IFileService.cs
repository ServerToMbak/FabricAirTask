namespace FabricAirTask.Services
{
    public interface IFileService
    {
        public Entity.File AddFile(Entity.File file);
        public List<Entity.File> GetAll();
    }
}
