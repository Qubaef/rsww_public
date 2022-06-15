using ApiGateway.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.DataModels.User;
using System.Security.Claims;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly AuthService _authService;

        public UserController(ILogger<UserController> logger, AuthService authService)
        {
            _logger = logger;
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserCredentials userCredentials)
        {
            var user = _authService.FindUser(userCredentials);

            if (user is not null)
            {
                var claims = new List<Claim>
                {
                    new(ClaimTypes.Name,userCredentials.Username),
                    new("Id", user.Id.ToString()),
                    new(ClaimTypes.Role, "User"),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return Ok();
            }

            return BadRequest();
        }

        [Authorize]
        [HttpGet("get-logged-id")]
        public Dictionary<string, string> GetLoggedUserId()
        {
            var userId = User.FindFirst("Id")?.Value;
            var username = User.FindFirst(ClaimTypes.Name)?.Value;

            return new Dictionary<string, string>()
            {
                {"Id", userId},
                {"Name", username}
            };
        }

        [Authorize]
        [HttpPost("logout")]
        public void Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}