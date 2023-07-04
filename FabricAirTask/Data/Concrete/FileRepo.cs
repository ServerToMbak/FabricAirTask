using FabricAirTask.Data.Abstract;

namespace FabricAirTask.Data.Concrete
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

        public List<Entity.File> GetFilesByUserId(int userId)
        {
            return _context.Files.Where(opt => opt.UserId == userId).ToList();
        }

        public List<Entity.File> GetFilesByUserName(string name)
        {
            return _context.Files.Where(opt => opt.Name.ToLower().Equals(name.ToLower())).ToList();
        }

        public Entity.File Update(Entity.File file)
        {
            throw new NotImplementedException();
        }
    }
}
