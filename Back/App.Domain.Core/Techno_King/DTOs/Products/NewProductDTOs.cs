using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace App.Domain.Core.Techno_King.DTOs.Products
{
    public class NewProductDTOs
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        [Range(0, 100, ErrorMessage = "The discount percentage must be between 0 and 100 percent!")]
        public int DiscountPercentage { get; set; }
        public int SubCategoryId { get; set; }
        public string? ImageURL1 { get; set; }
        public IFormFile? ProfileImgFile1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public IFormFile? ProfileImgFile2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public IFormFile? ProfileImgFile3 { get; set; }
    }
}
