using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]// get all users request.
        public async Task<ActionResult<List<User>>> GetAllUser()
        {
           return Ok(await _userService.GetAllUsers());

        }
        [Authorize(Roles ="Admin")]
        [HttpGet("getuserinfo")]// get specific user information request.
                                //it will give the user's name, email and role as user information Data Transfer Object 
                                //I need to make the name unique its not  unique yet. FluentValidation can be used. 
        public async Task<ActionResult<UserDto>> GetUserByName(string name)
        {
            var response =await _userService.GetUserByName(name);
            
            if(response == null) 
            {
                return NotFound();
            }
            return Ok(_userService.GetUserByName(name));
        }
    }
}
