using Microsoft.AspNetCore.Mvc;
using Core.Entities.Models;
using Core.Entities.InputModels;
using Microsoft.AspNetCore.Authorization;

namespace BookingService.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Register", Name = "Register")]
        public IActionResult Register(RegisterInfo info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessage code = new CodeMessage();
                code.code = "201";
                code.message = "Okay";
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("Login", Name = "Login")]
        public IActionResult Login(LoginInfo info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessageWithData<UserInfo> code = new CodeMessageWithData<UserInfo>();
                code.code = "201";
                code.message = "Okay";
                code.data = user;
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [HttpPost("GetProfile", Name = "GetProfile")]
        public IActionResult GetProfile(UserInputInfo info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessageWithData<UserInfo> code = new CodeMessageWithData<UserInfo>();
                code.code = "201";
                code.message = "Okay";
                code.data = user;
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost("ChangePassword", Name = "ChangePassword")]
        public IActionResult ChangePassword(UserInputInfo info)
        {
            try
            {
                UserInfo user = new UserInfo();
                CodeMessage code = new CodeMessage();
                code.code = "201";
                code.message = "Okay";
                return Ok(code);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
