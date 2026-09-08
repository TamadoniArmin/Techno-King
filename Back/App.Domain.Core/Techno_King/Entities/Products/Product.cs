using App.Domain.Core.Techno_King.Entities.Card;
using App.Domain.Core.Techno_King.Entities.Catrgories;
using App.Domain.Core.Techno_King.Entities.Comments;
using App.Domain.Core.Techno_King.Enum;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.Techno_King.Entities.Products
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float DiscountedPrice => Price - (Price * DiscountPercentage / 100f);
        public string Description { get; set; }
        public string Brand { get; set; }
        public int DiscountPercentage { get; set; }
        public int SubCategoryId { get; set; }
        public int InventoryQuantity { get; set; }
        public bool IsAvailable => InventoryQuantity > 0;
        public float AverageRating { get; set; }
        public int SalesCount { get; set; }
        public List<int>? CommentsId { get; set; }
        public DateTime CreatedAt { get; set; }


        public string? ImageUrl1 { get; set; } //  (Main Image)
        public string? ImageUrl2 { get; set; } //  (Optional)
        public string? ImageUrl3 { get; set; } //  (Optional)

        public bool IsDeleted { get; set; }
        #endregion

        #region NavigationProperties
        public Category? SubCategory { get; set; }
        public List<ShoppingCard>? ShoppingCards { get; set; }
        public List<Comment>? Comments { get; set; }
        #endregion
    }
}