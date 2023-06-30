using FabricAirTask.Entity;

namespace FabricAirTask.Services
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
        public User GetUserByName(string name);
    }
}
