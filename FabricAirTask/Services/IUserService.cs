using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Services
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
        public UserDto GetUserByName(string name);
    }
}
