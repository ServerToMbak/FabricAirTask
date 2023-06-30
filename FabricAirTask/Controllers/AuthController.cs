using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace FabricAirTask.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController :ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public  ActionResult<string> Register(RegisterDto user)
        {
            var response =  _authService.Register(new User { Id = user.Id, Email=user.Email, Name = user.Name}, user.Password);

            return Ok(response);
        }
        [HttpPost("login")]
        public ActionResult<User> Login(LoginDto login) 
        {
            return Ok(_authService.Login(login.Email, login.Password));
        }
    }
}
