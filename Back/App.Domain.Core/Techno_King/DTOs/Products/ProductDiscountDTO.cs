using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductDiscountDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public float OriginalPrice { get; set; }
    public int DiscountPercentage { get; set; }
    public float FinalPrice { get; set; }
    public string? Brand { get; set; }
    public int SubCategoryId { get; set; }
    public string? ImageUrl1 { get; set; }
    public string? ImageUrl2 { get; set; }
    public string? ImageUrl3 { get; set; }
}
