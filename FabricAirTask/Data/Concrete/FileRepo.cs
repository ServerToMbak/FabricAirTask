using FabricAirTask.Data.Abstract;
using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace FabricAirTask.Data.Concrete
{
    public class FileRepo : IFileRepo
    {
        private AppDbContext _context;

        public FileRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Entity.File> Add(Entity.File file)
        {
            var response = _context.Files.Add(file);
            await _context.SaveChangesAsync();

            return file;
        }

        public async Task<List<Entity.File>> GetAll()
        {
            return await _context.Files.ToListAsync();
        }

        public async Task<List<Entity.File>> GetFilesByUserId(int userId)
        {
            return await _context.Files.Where(opt => opt.UserId == userId).ToListAsync();
        }
        public async Task<List<Entity.File>> GetFilesByUserIdAndByFileType(FileType fileType,int userId)
        {
            return await _context.Files.Where(opt => opt.UserId == userId && opt.FileType ==fileType).ToListAsync();
        }

        public async Task<List<Entity.File>> GetFilesByUserName(string name)
        {
            return await _context.Files.Where(opt => opt.Name.ToLower().Equals(name.ToLower())).ToListAsync();
        }

        public Task<Entity.File> Update(Entity.File file)
        {
            throw new NotImplementedException();
        }
    }
}
