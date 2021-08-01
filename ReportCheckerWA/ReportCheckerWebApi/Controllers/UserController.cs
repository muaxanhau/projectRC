using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using User = ReportCheckerWebApi.Features.User;

namespace ReportCheckerWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly User.Login.Method loginMethod;

        public UserController(User.Login.Method loginMethod)
        {
            this.loginMethod = loginMethod;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] User.Login.RequestBody requestBody)
        {
            var token = loginMethod.Execute(requestBody.Username, requestBody.Password);
            if (token is null)
            {
                return Unauthorized();
            }
            var reponse = new User.Login.ReponseBody(token);

            return Ok(reponse);
        }

        [HttpGet("check-token")]
        public IActionResult CheckToken()
        {
            return NoContent();
        }
    }
}
