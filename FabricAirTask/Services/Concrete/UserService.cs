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
        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepo.GetAllUser();
        }

        public async Task<UserDto> GetUserByName(string name)
        {
            var user =await _userRepo.GetUserByName(name);

            var userDto =  _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
