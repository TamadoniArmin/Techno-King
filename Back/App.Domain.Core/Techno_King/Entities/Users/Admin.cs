using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.Entities.Users
{
    public class Admin
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public UserBase? UserBase { get; set; }
    }
}
