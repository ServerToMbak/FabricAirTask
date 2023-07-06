using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Services.Abstract
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
        public Task<UserDto> GetUserByName(string name);
    }
}
