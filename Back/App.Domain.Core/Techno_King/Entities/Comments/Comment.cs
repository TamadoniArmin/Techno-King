using App.Domain.Core.Techno_King.Entities.Orders;
using App.Domain.Core.Techno_King.Entities.Products;
using App.Domain.Core.Techno_King.Entities.Users;
using App.Domain.Core.Techno_King.Enum;

namespace App.Domain.Core.Techno_King.Entities.Comments
{
    public class Comment
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public CommentStatusEnum Status { get; set; }
        public DateTime SetAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        #endregion
        #region NavigationProperties
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        #endregion
    }
}
