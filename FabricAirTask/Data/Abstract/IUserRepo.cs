using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Data.Abstract
{
    public interface IUserRepo
    {
        public void AddUser(User user);
        public List<User> GetAllUser();
        public User GetUserByName(string name);
        public User GetByEmail(string email);
        public bool UserExist(string email);
    }
}
