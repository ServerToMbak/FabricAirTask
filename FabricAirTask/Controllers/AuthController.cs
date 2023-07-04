using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services.Abstract;
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

        [HttpPost("register")]// Add a new user request
        public  ActionResult<string> Register(RegisterDto user)
        {
            var response =  _authService.Register(new User { Id = user.Id, Email=user.Email, Name = user.Name}, user.Password);

            return Ok(response);
        }
        [HttpPost("login")]
        public ActionResult<string> Login(LoginDto login) 
        {
            var response = _authService.Login(login);
            return Ok(response);
        }
    }
}
