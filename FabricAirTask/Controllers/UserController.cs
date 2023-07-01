using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace FabricAirTask.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class UserController :ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAllUser()
        {
           return Ok(_userService.GetAllUsers());

        }
        [HttpGet("getuserinfo")]
        public ActionResult<UserDto> GetUserByName(string name)
        {
            var response = _userService.GetUserByName(name);
            
            if(response == null) 
            {
                return NotFound();
            }
            return Ok(_userService.GetUserByName(name));
        }
    }
}
