using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Products;
using App.Domain.Core.Techno_King.Enum;
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

        [HttpGet("Sort")]
        public async Task<IActionResult> GetProductsSortedAsync(
            [FromQuery] ProductSortType sortBy,
            [FromQuery] bool ascending = true,
            CancellationToken cancellationToken = default)
        {
            var products = sortBy switch
            {
                ProductSortType.Price =>
                    await productAppService.GetProductsSortedByPriceAsync(ascending, cancellationToken),

                ProductSortType.Rating =>
                    await productAppService.GetProductsSortedByRatingAsync(ascending, cancellationToken),

                ProductSortType.SalesCount =>
                    await productAppService.GetProductsSortedBySalesCountAsync(ascending, cancellationToken),

                ProductSortType.DiscountPercentage =>
                    await productAppService.GetProductsSortedByDiscountPercentageAsync(ascending, cancellationToken),

                ProductSortType.CreatedAt =>
                    await productAppService.GetProductsSortedByCreatedAtAsync(ascending, cancellationToken),

                _ => await productAppService.GetProductsSortedByCreatedAtAsync(ascending, cancellationToken)
            };

            return Ok(products);
        }

        #endregion
    }
}
