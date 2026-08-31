using Microsoft.AspNetCore.Http;

namespace App.Domain.Core.Techno_King.DTOs.Users
{
    public class UpdateUserInfoDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserName { get; set; }
        public string? Mobile { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string? ImagePath { get; set; }
    }
}
