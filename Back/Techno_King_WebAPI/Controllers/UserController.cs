using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Techno_King_WebAPI.WebFramework.ApiHelper;
using Techno_KingAppService.Techno_King.Users;


namespace Techno_King_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserAppService userAppService) : Controller
    {
        [HttpGet("Get all Users")]
        public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
        {
            var allUsers = await userAppService.GetAllUsersAsync(cancellationToken);
            var result = new ApiResult<List<GetUserBaseForViewPage>, int, int>
            {
                IsSuccess = true,
                Massage = "عملیات با موفقیت انجام شد",
                Result1 = allUsers
            };
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<IdentityResult> Register(UserToCreateDTO model, CancellationToken cancellationToken)
        {
            return await userAppService.Register(model, cancellationToken);
        }

        [HttpPost("Login")]
        public async Task<IdentityResult> Login(string username, string password, bool rememberMe)
        {
            return await userAppService.Login(username, password, rememberMe);
        }

        [HttpGet("Current User")]
        public async Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken)
        {
            var Result= await userAppService.GetCurrentUserAsync();
            if(Result is null || Result.Id == 0)
            {
                return Ok("در حال حاضر کاربری وارد نشده است.");
            }
            else
            {
                return Ok(Result);
            }
        }

        [HttpPut("Update")]
        [Authorize]
        public async Task<IActionResult> UpdateUser(UpdateUserInfoDTO NewData,CancellationToken cancellationToken)
        {
            var CurrentUser = userAppService.GetCurrentUserAsync();
            if (CurrentUser != null)
            {
                var Result = await userAppService.UpdateUserInfo(NewData, CurrentUser.Result.Id!, cancellationToken);
                return Ok(Result);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await userAppService.LogoutAsync();
            return Ok("کاربر با موفقیت خارج شد");
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId, CancellationToken cancellationToken)
        {
            var result = await userAppService.DeleteUser(userId, cancellationToken);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User deleted successfully");
        }

    }
}
