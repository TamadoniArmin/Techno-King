using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Techno_King_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductAppService productAppService) : ControllerBase
    {
        #region Create
        [HttpPost("AddProduct")]
        public async Task<IActionResult> CreateProduct(NewProductDTOs productDto, CancellationToken cancellationToken)
        {
            var Result = await productAppService.AddProductasync(productDto, cancellationToken);
            if (Result)
            {
                return Ok("Product created successfully.");
            }
            else
            {
                return BadRequest("Failed to create product.");
            }
        }
        #endregion
        #region ReadOnly
        [HttpGet("GetById")]
        public async Task<IActionResult> GetProduct(int id, CancellationToken cancellationToken)
        {
            var product = await productAppService.GetProductByIdAsync(id, cancellationToken);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllProducts(CancellationToken cancellationToken)
        {
            var products = await productAppService.GetAllProductsAsync(cancellationToken);
            return Ok(products);
        }

        [HttpGet("GetProductsBySubcategoryId")]
        public async Task<IActionResult> GetProductsBySubcategoryId(int subcategoryId, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsBySubCategoryIdAsync(subcategoryId, cancellationToken);
            return Ok(products);
        }

        [HttpGet("GetProductsWithDiscount")]
        public async Task<IActionResult> GetProductsWithDiscount(CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsWithDiscountAsync(cancellationToken);
            return Ok(products);
        }

        [HttpGet("GetHighDiscountProducts")]
        public async Task<IActionResult> GetHighDiscountProducts(CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsWithHighDiscountAsync(cancellationToken);
            return Ok(products);
        }

        [HttpGet("GetUpToDiscountProducts")]
        public async Task<IActionResult> GetProductsUpToDiscountAsync(int maxDiscountPercentage, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsUpToDiscountAsync(maxDiscountPercentage, cancellationToken);
            return Ok(products);
        }

        [HttpGet("SearchByName")]
        public async Task<IActionResult> SearchProductsByName(string name, CancellationToken cancellationToken)
        {
            var products = await productAppService.SearchProductsByNameAsync(name, cancellationToken);
            return Ok(products);
        }

        [HttpGet("ByBrand")]
        public async Task<IActionResult> GetbyBrand(string brand, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetbyBrandAsync(brand, cancellationToken);
            return Ok(products);
        }
        [HttpGet("TopSelling")]
        public async Task<IActionResult> GetTopNSellingProducts(int n, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetTopNSellingProductsAsync(n, cancellationToken);
            return Ok(products);
        }

        [HttpGet("TopRated")]
        public async Task<IActionResult> GetTopNHighestRatedProducts(int n, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetTopNHighestRatedProductsAsync(n, cancellationToken);
            return Ok(products);
        }
        #endregion
        #region Sorting
        [HttpGet("SortByPrice")]
        public async Task<IActionResult> GetProductsSortedByPriceAsync(bool ascending, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsSortedByPriceAsync(ascending, cancellationToken);
            return Ok(products);
        }
        [HttpGet("SortByRating")]
        public async Task<IActionResult> GetProductsSortedByRatingAsync(bool ascending, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsSortedByRatingAsync(ascending, cancellationToken);
            return Ok(products);
        }
        [HttpGet("SortBySalesCount")]
        public async Task<IActionResult> GetProductsSortedBySalesCountAsync(bool ascending, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsSortedBySalesCountAsync(ascending, cancellationToken);
            return Ok(products);
        }
        [HttpGet("SortByDiscountPercentage")]
        public async Task<IActionResult> GetProductsSortedByDiscountPercentageAsync(bool ascending, CancellationToken cancellationToken)
        {
            var products = await productAppService.GetProductsSortedByDiscountPercentageAsync(ascending, cancellationToken);
            return Ok(products);
        }
        #endregion
    }
}
