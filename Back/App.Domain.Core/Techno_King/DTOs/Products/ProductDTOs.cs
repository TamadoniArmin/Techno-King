using Microsoft.AspNetCore.Http;

namespace App.Domain.Core.Techno_King.DTOs.Products
{
    public class ProductDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int DiscountPercentage { get; set; }
        public int SubCategoryId { get; set; } = 0;
        public float AverageRating { get; set; }
        public int SalesCount { get; set; }
        public string? ImageUrl1 { get; set; }
        public IFormFile? ProfileImgFile1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public IFormFile? ProfileImgFile2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public IFormFile? ProfileImgFile3 { get; set; }
        public bool IsDeleted { get; set; }
    }
}
