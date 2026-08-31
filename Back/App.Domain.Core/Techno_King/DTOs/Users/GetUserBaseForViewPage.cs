using App.Domain.Core.Techno_King.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.DTOs.Users
{
    public class GetUserBaseForViewPage
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public int? AdminId { get; set; }
        public int? CustomerId { get; set; }
        public int? ExpertId { get; set; }
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public DateTime RegisterAt { get; set; }
        public RoleEnum Role { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
        public string? ImagePath { get; set; }
    }
}
