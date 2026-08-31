using App.Domain.Core.Techno_King.Entities.Card;
using App.Domain.Core.Techno_King.Entities.Comments;
using App.Domain.Core.Techno_King.Entities.Users;
using App.Domain.Core.Techno_King.Enum;

namespace App.Domain.Core.Techno_King.Entities.Orders
{
    public class Order
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public OrderStatusEnum StatusEnum { get; set; }
        public PaymentStatusEnum paymentStatusEnum { get; set; }
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public int ShoppingCardId { get; set; }
        public DateTime SetAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion
        #region NavigationProperties
        public ShoppingCard ShoppingCard { get; set; }
        public Customer Customer { get; set; }
        #endregion
    }
}
