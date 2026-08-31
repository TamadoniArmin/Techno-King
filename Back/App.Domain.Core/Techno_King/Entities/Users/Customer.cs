using App.Domain.Core.Techno_King.Entities.Card;
using App.Domain.Core.Techno_King.Entities.Comments;
using App.Domain.Core.Techno_King.Entities.Orders;
using App.Domain.Core.Techno_King.Entities.Products;

namespace App.Domain.Core.Techno_King.Entities.Users
{
    public class Customer
    {
        #region Properties
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        #endregion
        #region NavigationProperties
        public List<Product>? CurrentShoppingCard { get; set; }
        public List<Order>? Orders { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ShoppingCard> ShoppingCards { get; set; }
        public UserBase? UserBase { get; set; }
        #endregion

    }
}
