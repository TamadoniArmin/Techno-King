using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.DTOs.Products
{
    public class ProductDiscountUpdateDto
    {
        public int ProductId { get; set; }
        [Range(0, 100, ErrorMessage = "The discount percentage must be between 0 and 100 percent!")]
        public int DiscountPercentage { get; set; }
    }
}
