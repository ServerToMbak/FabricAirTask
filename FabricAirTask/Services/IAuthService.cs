using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Services
{
    public interface IAuthService
    {
        public string Login(LoginDto login);
        public string Register(User user, string password);
    }
}
