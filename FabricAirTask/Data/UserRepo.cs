using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace FabricAirTask.Data
{
    public class UserRepo : IUserRepo
    {
        private AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges(); 
        }

        public List<User> GetAllUser(User user)
        {
            return _context.Users.ToList();
        }

        public  User GetByEmail(string email)
        {
            return  _context.Users.FirstOrDefault(o => o.Email.ToLower().Equals(email.ToLower()));
            
        }

        public User GetUserByName(string name)
        {
            return _context.Users.FirstOrDefault(o => o.Name.ToLower().Equals(name.ToLower()));
        }

        public  bool UserExist(string email)
        {
            if ( _context.Users.Any(x => x.Email.ToLower().Equals(email.ToLower())))
            {
                return true;
            }
            return false;
        }
    }
}
