using Entity.ResponseMessage;
using Entity.Users.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System.Net;
using System.Security.Claims;

namespace DogovorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var returnMessage = await _userService.RegisterUser(dto);
            if(returnMessage.Contains("400"))
                return BadRequest(returnMessage);
            else
                return Ok(returnMessage);        
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(AuthorizationDTO dto)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            var returnMessage = await _userService.Login(dto);
            if(returnMessage.Contains("400"))
                return BadRequest(returnMessage);
            return Ok("Json web token = " + returnMessage);
        }
        [HttpGet("CurrentUser")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> CurrentUser()
        {
            var claim = User.Identity as ClaimsIdentity;
            if (claim == null) return BadRequest(400);
            var userInfo = await _userService.UsersInformation(claim); 
            return Ok(userInfo);
        }
        [HttpPost("SendEmailMessage")]
        public async Task<IActionResult> SendEmailMessage(MailResetDTO dTO)
        {
            var message = await _userService.SendEmailCode(dTO);
            if(!message.Contains("200"))
                return BadRequest(new Response { Status = "Error", Message = message.ToString() });
            return Ok(message);
        }
        [HttpPost("VarifyUser")]
        public ActionResult VerifyUser(RandomNumberDTO dto)
        {
            var UserEmail = _userService.VerifyUser(dto);
            if (UserEmail.Contains("Error")) { return BadRequest(UserEmail); };
            return Ok(new Response { Status = "Ok", Message = "Verification success!" });
        }
        [HttpPut("UpdatePassword")]
        public async Task<ActionResult> ResetPassword(NewPasswordDTO dto)
        {
            var reset = await _userService.ResetPassword(dto);
            if (reset == null)
                return BadRequest(new Response { Status = "Error", Message = "Password was not updated!" });
            return Ok(new Response { Status = "Success!", Message = "The Password is updated successfully" });
        }
    }
}
