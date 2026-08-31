using App.Domain.Core.Techno_King.Entities.Products;

namespace App.Domain.Core.Techno_King.Entities.Catrgories
{
    public class Category
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public string? ImagePath { get; set; }
        public bool IsDeleted { get; set; } = false;
        #endregion
        #region NavigationProperties
        public List<Category>? Subcategories { get; set; }
        public Category? ParentCategory { get; set; }
        public List<Product>? Products { get; set; }
        #endregion
    }
}
