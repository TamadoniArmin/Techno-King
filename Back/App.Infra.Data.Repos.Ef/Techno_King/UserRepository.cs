using App.Domain.Core.Techno_King.Data.Repositories;
using App.Domain.Core.Techno_King.DTOs.Users;
using Connection.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Techno_King
{
    public class UserRepository : IUserRepository
    {
        #region Dependency Injection
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion
        #region Read
        public async Task<List<GetUserBaseForViewPage>> GetAllAsync(CancellationToken cancellationToken)
        {
            var Result = await _appDbContext
                .Users
                .Where(x => x.IsDeleted == false)
                .Select(x => new GetUserBaseForViewPage()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    FullName = x.FirstName + " " + x.LastName,
                    UserName = x.UserName ?? string.Empty,
                    Mobile = x.Mobile,
                    Email = x.Email,
                    RegisterAt = x.RegisteredAt,
                    Role = x.Role,
                    ImagePath = x.ImagePath
                }).ToListAsync(cancellationToken);
            return Result;
        }
        public async Task<UserBaseDTO?> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _appDbContext
                .Users
                .Where(x=>x.Id == id && x.IsDeleted==false)
                .Select(x => new UserBaseDTO()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserName= x.UserName,
                    Mobile = x.Mobile,
                    Email = x.Email,
                    ImagePath=x.ImagePath
                }).FirstOrDefaultAsync(cancellationToken);
        }
        #endregion

    }
}
