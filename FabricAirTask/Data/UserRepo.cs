using FabricAirTask.Dto;
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
            var users = _context.Users.ToList();//instead of usinf FirstOrDefault method data get
            //with this way to taking all data in a List and then checking the email if its exist
            //because oracle 10 g made a problem with compability of working with LİNQ
           foreach(var user in users) 
           {
                if (user.Email.ToLower()  == email.ToLower())
                {
                    return user;
                }
           }
            return null;
        }

        public User GetUserByName(string name)
        {
            var result = _context.Users.ToList();//same reason with finding the mail method because of LİNQ
            foreach (var user in result)
            {
                if(user.Name.ToLower() == name.ToLower())
                {
                    return user;
                }
            }
            return null;
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
