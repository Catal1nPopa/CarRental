using CarRentail.Application.Mediator;
using CarRentail.Application.Requests;
using CarRentail.Application.Services;
using CarRentail.Domain.Entities.Auth;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserServices userServices, IMediator mediator) : ControllerBase
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
                SendEmail.SendEmailException(ex, mediator);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            if (user.password.IsNullOrEmpty() || user.username.IsNullOrEmpty())
                return BadRequest();
            try
            {

               var req = await userServices.register(user);
               if (req.Equals("existent"))
                   return BadRequest();
               else
                return Ok();
            }
            catch (Exception ex)
            {
                SendEmail.SendEmailException(ex, mediator);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("SchimbareParola")]
        public async Task<IActionResult> UpdatePassword([FromBody] User user)
        {
            if (user.username.IsNullOrEmpty())
                return BadRequest();
            try
            {
                var update = await userServices.updatePassword(user);
                return Ok();
            }
            catch (Exception ex)
            {
                SendEmail.SendEmailException(ex, mediator);
                return BadRequest(ex.Message);
            }
        }
    }
}
