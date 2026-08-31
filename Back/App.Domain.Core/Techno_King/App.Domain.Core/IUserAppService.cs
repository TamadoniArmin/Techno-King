using App.Domain.Core.Techno_King.DTOs.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.App.Domain.Core
{
    public interface IUserAppService
    {
        #region Create
        public Task<IdentityResult> Register(UserToCreateDTO model, CancellationToken cancellationToken);
        #endregion
        #region Read
        public Task<IdentityResult> Login(string username, string password, bool rememberMe);
        Task<List<GetUserBaseForViewPage>> GetAllUsersAsync(CancellationToken cancellationToken);
        public Task<UserDTO?> GetCurrentUserAsync();
        public Task<UserBaseDTO> GetByIdAsync(int id, CancellationToken cancellationToken);
        #endregion
        #region Update
        public Task<IdentityResult> UpdateUserInfo(UpdateUserInfoDTO userDto, int userId, CancellationToken cancellationToken);
        public Task LogoutAsync();
        #endregion
        #region Delete
        public Task<IdentityResult> DeleteUser(int UserId, CancellationToken cancellationToken);
        #endregion
    }
}
