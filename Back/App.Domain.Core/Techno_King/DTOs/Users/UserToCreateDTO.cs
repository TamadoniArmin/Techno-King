using App.Domain.Core.Techno_King.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.DTOs.Users
{
    public class UserToCreateDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
        public int Balance { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
        public bool IsDeleted { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
        public string? ImagePath { get; set; }
        public int? SuperAdminId { get; set; }
        public int? AdminId { get; set; }
        public int? CustomerId { get; set; }
        public bool CreatedBySuperAdmin { get; set; }
    }
}
