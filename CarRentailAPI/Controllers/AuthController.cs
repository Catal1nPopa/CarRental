using CarRentail.Application.Services;
using CarRentail.Domain.Entities.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserServices userServices) : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserModel userModel)
        {
            var user = new User(userModel.username, userModel.password);
            try
            {
                var token = await userServices.login(user);
                if (!token.Equals("error"))
                {

                return Ok(new
                {
                    token,
                    Message = "Login Success"
                });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            try
            {
                await userServices.register(user);
                return Ok("Registration successful.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
