using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Services.Abstract
{
    public interface IAuthService
    {
        public Task<string> Login(LoginDto login);
        public Task<string> Register(User user, string password);
    }
}
