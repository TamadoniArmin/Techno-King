using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Users;
using App.Domain.Core.Techno_King.Entities.Users;
using App.Domain.Core.Techno_King.Enum;
using App.Domain.Core.Techno_King.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Techno_KingAppService.Techno_King.Users
{
    public class UserAppService : IUserAppService
    {
        #region Dependency Injection
        private readonly UserManager<UserBase> _userManager;
        private readonly SignInManager<UserBase> _signInManager;
        private readonly IPasswordHasher<UserBase> _passwordHasher;
        private readonly ILogger<UserAppService> _logger;
        private readonly IMemoryCache _memoryCache;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IGeneralService _generalService;
        private readonly IUserService _userService;


        public UserAppService(UserManager<UserBase> userManager,
            SignInManager<UserBase> signInManager,
            IPasswordHasher<UserBase> passwordHasher,
            ILogger<UserAppService> logger,
            IMemoryCache memoryCache,
            IHttpContextAccessor httpContextAccessor,
            IGeneralService generalService,
            IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
            _logger = logger;
            _memoryCache = memoryCache;
            _httpContextAccessor = httpContextAccessor;
            _generalService = generalService;
            _userService = userService;
        }
        #endregion
        #region Create
        public async Task<IdentityResult> Register(UserToCreateDTO model, CancellationToken cancellationToken)
        {
            string role = string.Empty;

            //if (model.ProfileImgFile is not null)
            //{
            //    model.ImagePath = await _generalService.UploadImage(model.ProfileImgFile!, "Profiles", cancellationToken);
            //}
            var user = new UserBase
            {
                UserName = model.Username,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Mobile = model.Mobile,
                Role = model.Role,
                Balance = 1000000,
                RegisteredAt = DateTime.Now,
                ImagePath = model.ImagePath ?? null
            };

            if (model.Role == RoleEnum.SuperAdmin)
            {
                role = "SuperAdmin";
            }

            if (model.Role == RoleEnum.Admin)
            {
                role = "Admin";
                user.Admin = new Admin()
                {
                };
            }

            if (model.Role == RoleEnum.Customer)
            {
                role = "Customer";
                user.Customer = new Customer()
                {
                };
            }

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {

                await _userManager.AddToRoleAsync(user, role);


                if (model.Role == RoleEnum.Customer)
                {
                    await _userManager.AddClaimAsync(user, new Claim("CustomerId", user.Customer.Id.ToString()));
                }

                if (!model.CreatedBySuperAdmin && model.Role == RoleEnum.Admin)
                {
                    await _userManager.AddClaimAsync(user, new Claim("AdminId", user.Admin.Id.ToString()));
                }
                if (!model.CreatedBySuperAdmin)
                {
                    await _signInManager.PasswordSignInAsync(user.UserName, model.Password, true, false);
                }
            }
            if (!result.Succeeded)
            {
                _logger.LogWarning("{Time}کاربری با نام کاربری{Usernam} نتوانست ثبتنام کند", DateTime.UtcNow.ToLongTimeString(), user.UserName);
            }
            else if (result.Succeeded)
            {
                _logger.LogInformation("کاربری با نام کاربری {Username} درساعت {Time} با موفقیت ثبتنام کرد", DateTime.UtcNow.ToLongTimeString(), user.UserName);
            }
            return result;

        }
        #endregion
        #region Read
        public async Task<List<GetUserBaseForViewPage>> GetAllUsersAsync(CancellationToken cancellationToken)
        {
            List<GetUserBaseForViewPage> WantedUsers;
            if (_memoryCache.Get("AllUsers") is not null)
            {
                WantedUsers = _memoryCache.Get<List<GetUserBaseForViewPage>>("AllUsers");
            }
            else
            {
                WantedUsers = await _userService.GetAllAsync(cancellationToken);
                _memoryCache.Set("AllUsers", WantedUsers,
                    new MemoryCacheEntryOptions
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(10)
                    }
                    );
            }
            return WantedUsers;
        }

        public async Task<UserDTO?> GetCurrentUserAsync()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            if (user == null || !user.Identity.IsAuthenticated)
            {
                return null;
            }

            string cacheKey = $"User_{user.Identity.Name}";
            if (!_memoryCache.TryGetValue(cacheKey, out UserDTO userDTO))
            {
                var applicationUser = await _userManager.GetUserAsync(user);
                if (applicationUser == null)
                {
                    return null;
                }

                userDTO = new UserDTO
                {
                    Id = applicationUser.Id,
                    FullName = applicationUser.FirstName + " " + applicationUser.LastName ?? applicationUser.Email ?? "کاربر بدون نام!!!!!",
                    ProfileImageUrl = applicationUser.ImagePath ?? "~/images/Profiles/dummy-avatar.jpg"
                };

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));
                _memoryCache.Set(cacheKey, userDTO, cacheOptions);
            }

            return userDTO;
        }

        public async Task<UserBaseDTO> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _userService.GetByIdAsync(id, cancellationToken);
        }
        #endregion
        #region Update
        private string UpdateIfChanged(string currentValue, string newValue)
        {
            if (!string.IsNullOrWhiteSpace(newValue) && currentValue != newValue)
            {
                return newValue;
            }
            return currentValue;
        }

        public async Task<IdentityResult> Login(string username, string password, bool rememberMe)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, rememberMe, false);
            _logger.Log(logLevel: LogLevel.Warning, "User Logged In");
            return result.Succeeded ? IdentityResult.Success : IdentityResult.Failed();
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<IdentityResult> UpdateUserInfo(UpdateUserInfoDTO userDto, int userId, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                _logger.LogWarning("کاربری با شناسه {UserId} یافت نشد.", userId);
                return IdentityResult.Failed(new IdentityError { Description = "کاربر یافت نشد." });
            }
            else
            {
                user.UserName = UpdateIfChanged(user.UserName, userDto.UserName);
                user.FirstName = UpdateIfChanged(user.FirstName, userDto.FirstName);
                user.LastName = UpdateIfChanged(user.LastName, userDto.LastName);
                user.Email = UpdateIfChanged(user.Email, userDto.Email);
                user.Mobile = UpdateIfChanged(user.Mobile, userDto.Mobile);

                //if (userDto.ProfileImgFile != null)
                //{
                //    user.ImagePath = await _generalService.UploadImage(userDto.ProfileImgFile, "Profiles", cancellationToken);
                //}

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    _logger.LogInformation("کاربر با شناسه {UserId} در ساعت {Time} با موفقیت به‌روزرسانی شد.", userId, DateTime.UtcNow.ToLongTimeString());
                }
                else
                {
                    _logger.LogWarning("به‌روزرسانی کاربر با شناسه {UserId} در ساعت {Time} ناموفق بود.", userId, DateTime.UtcNow.ToLongTimeString());
                }

                return result;
            }
        }
        #endregion
        #region Delete
        public async Task<IdentityResult> DeleteUser(int UserId, CancellationToken cancellationToken)
        {
            var StringId = Convert.ToString(UserId);
            var user = await _userManager.FindByIdAsync(StringId);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "کاربر یافت نشد." });
            }

            user.IsDeleted = true;
            var result = await _userManager.UpdateAsync(user);
            return result;
        }
        #endregion
    }
}
