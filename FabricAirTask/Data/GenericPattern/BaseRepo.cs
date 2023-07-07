using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace FabricAirTask.Data.GenericPattern
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        public BaseRepo(AppDbContext context)
        {
            _context = context;

        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            await _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(X =>X. == id);
        }

        public Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
