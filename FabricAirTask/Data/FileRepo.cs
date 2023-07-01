namespace FabricAirTask.Data
{
    public class FileRepo : IFileRepo
    {
        private AppDbContext _context;

        public FileRepo(AppDbContext context)
        {
            _context = context;
        }
        public Entity.File Add(Entity.File file)
        {
            var response = _context.Files.Add(file);
            _context.SaveChanges();

            return file;
        }

        public List<Entity.File> GetAll()
        {
            return _context.Files.ToList();
        }

        public List<Entity.File> GetFilesByUserName(string name)
        {
            return null;
        }

        public Entity.File Update(Entity.File file)
        {
            throw new NotImplementedException();
        }
    }
}
