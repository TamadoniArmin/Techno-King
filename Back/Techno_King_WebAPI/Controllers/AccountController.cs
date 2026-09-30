using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Techno_King_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AccountController(IUserAppService userAppService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm]
            UserForRegisterDTO model,
            CancellationToken cancellationToken)
        {
            model.CreatedByAdmin = false;

            var result = await userAppService.Register(model, cancellationToken);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code ?? string.Empty, error.Description);
                }
                return ValidationProblem(ModelState);
            }

            return Ok(new { message = "Registration completed successfully." });
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login([FromForm]UserForLoginDTO model)
        {
            var result = await userAppService.Login(model.Email, model.Password, model.RememberMe);
            if (!result.Succeeded)
            {
                return Problem(
                    title: "Login failed",
                    detail: "Email or password is incorrect.",
                    statusCode: StatusCodes.Status401Unauthorized);
            }

            return Ok(new { message = "Logged in successfully." });
        }
    }
}