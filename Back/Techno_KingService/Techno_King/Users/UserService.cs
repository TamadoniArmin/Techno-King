using App.Domain.Core.Techno_King.Data.Repositories;
using App.Domain.Core.Techno_King.DTOs.Users;
using App.Domain.Core.Techno_King.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_KingService.Techno_King.Users
{
    public class UserService : IUserService
    {
        #region Dependency Injection
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion
        #region Read
        public async Task<List<GetUserBaseForViewPage>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _userRepository.GetAllAsync(cancellationToken);
        }

        public async Task<UserBaseDTO> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _userRepository.GetByIdAsync(id, cancellationToken);
        }
        #endregion
    }
}
