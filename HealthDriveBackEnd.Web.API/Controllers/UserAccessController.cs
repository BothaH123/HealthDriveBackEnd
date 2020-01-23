using HealthDriveBackEnd.Web.API.Interfaces;
using HealthDriveBackEnd.Web.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthDriveBackEnd.Web.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserAccessController : ControllerBase
    {
        private IUserAccessService _userService;

        public UserAccessController(IUserAccessService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
    }
}
