namespace FabricAirTask.Data.GenericPattern
{
    public interface IBaseRepo<T>
    {
        public Task Add(T entity);
        public Task Update(int id, T entity);
        public Task Delete(T entity);
        public Task<T> GetById(int id);
        public Task<List<T>> GetAll();
    }
}
