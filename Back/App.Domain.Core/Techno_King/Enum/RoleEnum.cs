using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.Enum
{
    public enum RoleEnum
    {
        [Display(Name = "سوپرادمین")]
        SuperAdmin = 1,

        [Display(Name = "ادمین")]
        Admin = 2,

        [Display(Name = "مشتری")]
        Customer = 3
    }
}
