using FabricAirTask.Entity;

namespace FabricAirTask.Services
{
    public interface IAuthService
    {
        public string Login(string email, string password);
        public string Register(User user, string password);
    }
}
