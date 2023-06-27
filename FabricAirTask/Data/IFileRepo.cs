namespace FabricAirTask.Data
{
    public interface IFileRepo
    {
        public Entity.File Add(Entity.File file);

        public List<Entity.File> getAll();
        public Entity.File Update(Entity.File file);
        
    }
}
