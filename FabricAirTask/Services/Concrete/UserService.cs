using AutoMapper;
using FabricAirTask.Data.Abstract;
using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services.Abstract;
using System.Runtime.CompilerServices;

namespace FabricAirTask.Services.Concrete
{
    public class UserService : IUserService
    {
        
        private IUserRepo _userRepo;
        private IMapper _mapper;

        public UserService(IUserRepo userRepo,IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUser();
        }

        public UserDto GetUserByName(string name)
        {
            var user = _userRepo.GetUserByName(name);

            var userDto =  _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
