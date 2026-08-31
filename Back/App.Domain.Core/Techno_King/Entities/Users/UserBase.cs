using App.Domain.Core.Techno_King.Enum;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.Techno_King.Entities.Users
{
    public class UserBase : IdentityUser<int>
    {
        #region
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Mobile { get; set; }
        public DateTime RegisteredAt { get; set; }
        public int Balance { get; set; } = 0;
        public int RoleId { get; set; }
        public RoleEnum Role { get; set; }
        public bool IsDeleted { get; set; }
        public string? ImagePath { get; set; }
        public int? SuperAdminId { get; set; }
        public int? AdminId { get; set; }
        public int? CustomerId { get; set; }
        #endregion
        #region NavigationProperties
        public RoleEnum NewRole { get; set; }
        public SuperAdmin? SuperAdmin { get; set; }
        public Admin? Admin { get; set; }
        public Customer? Customer { get; set; }
        #endregion
    }
}
