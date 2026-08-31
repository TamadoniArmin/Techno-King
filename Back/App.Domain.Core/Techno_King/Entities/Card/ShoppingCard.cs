using App.Domain.Core.Techno_King.Entities.Orders;
using App.Domain.Core.Techno_King.Entities.Products;
using App.Domain.Core.Techno_King.Entities.Users;
using App.Domain.Core.Techno_King.Enum;

namespace App.Domain.Core.Techno_King.Entities.Card
{
    public class ShoppingCard
    {
        #region Properties
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public ShoppingCardStatusEnum Status { get; set; }
        public bool IsDeleted { get; set; }
        #endregion
        #region NavigationProperties
        public List<Product> SelectedProducts { get; set; }
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        #endregion
    }
}
