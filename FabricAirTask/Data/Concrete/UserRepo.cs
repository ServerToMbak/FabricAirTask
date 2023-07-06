using FabricAirTask.Data.Abstract;
using FabricAirTask.Dto;
using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System.Linq;

namespace FabricAirTask.Data.Concrete
{
    public class UserRepo : IUserRepo
    {
        private AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<string> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return "The User Added";
        }

        public async Task<List<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
            var users =await _context.Users.ToListAsync();//instead of usinf FirstOrDefault method data get
                                                //with this way to taking all data in a List and then checking the email if its exist
                                                //because oracle 10 g made a problem with compability of working with LİNQ
            foreach (var user in users)
            {
                if (user.Email.ToLower() == email.ToLower())
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<User> GetUserByName(string name)
        {
            var result = await _context.Users.ToListAsync();//same reason with finding the mail method because of LİNQ
            foreach (var user in result)
            {
                if (user.Name.ToLower() == name.ToLower())
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<bool> UserExist(string email)
        {
            var response =await _context.Users.AnyAsync(x => x.Email.ToLower().Equals(email.ToLower()));
            if (response)
            {
                return true;
            }
            return false;
        }
    }
}
