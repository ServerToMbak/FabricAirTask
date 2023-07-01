using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.Linq;

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

        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public  User GetByEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(o => o.Email == email);
            if(user !=null) 
            {
                return user;
            }
            
            return null;
            
        }

        public User GetUserByName(string name)
        {
            string query = "SELECT * FROM Users WHERE Name = :name";
            return _context.Users.FirstOrDefault(opt => opt.Name.ToLower().Equals(name.ToLower()));


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
