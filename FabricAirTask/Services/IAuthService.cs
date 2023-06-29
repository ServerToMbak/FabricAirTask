using FabricAirTask.Entity;

namespace FabricAirTask.Services
{
    public interface IAuthService
    {
        public string Login(string username, string password);
        public string Register(User user, string password);
    }
}
