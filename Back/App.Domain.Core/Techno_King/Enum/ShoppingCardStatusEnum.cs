using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace App.Domain.Core.Techno_King.Enum
{
    public enum ShoppingCardStatusEnum
    {
        [Display(Name = "سبد ساخته شد")]
        Created = 1,

        [Display(Name = "تایید توسط مشتری")]
        ConfirmedbyCustomer = 2,

        [Display(Name = "تکمیل اطلاعات")]
        Complete_Information = 3,

        [Display(Name = "در حال پردازش")]
        Processing = 4,

        [Display(Name = "تایید شده توسط ادمین")]
        ConfirmedbyAdmin = 5,

        [Display(Name = "ارسال شد")]
        Sent = 6,
    }
}
