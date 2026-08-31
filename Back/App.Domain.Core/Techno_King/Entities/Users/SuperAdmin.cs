using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.Entities.Users
{
    public class SuperAdmin
    {
        public int Id { get; set; }
        public UserBase? UserBase { get; set; }
    }
}
