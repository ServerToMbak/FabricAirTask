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
    }
}
