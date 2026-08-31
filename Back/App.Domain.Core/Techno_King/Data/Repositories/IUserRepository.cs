using App.Domain.Core.Techno_King.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.Data.Repositories
{
    public interface IUserRepository
    {
        #region Read
        public Task<List<GetUserBaseForViewPage>> GetAllAsync(CancellationToken cancellationToken);
        public Task<UserBaseDTO> GetByIdAsync(int id, CancellationToken cancellationToken);
        #endregion
    }
}
