using FabricAirTask.Data;
using FabricAirTask.Entity;
using System.Runtime.CompilerServices;

namespace FabricAirTask.Services
{
    public class UserService : IUserService
    {
        
        private IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUser();
        }

        public User GetUserByName(string name)
        {
            return _userRepo.GetUserByName(name);
        }
    }
}
