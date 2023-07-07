using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Data.Abstract
{
    public interface IUserRepo
    {
        public Task<string> AddUser(User user);
        public Task Delete(int id);
        public Task getById(int id);
        public Task Update(int id, User user);
        public Task<List<User>> GetAllUser();
        public Task<User> GetUserByName(string name);
        public Task<User> GetByEmail(string email);
        public Task<bool> UserExist(string email);
    }
}
