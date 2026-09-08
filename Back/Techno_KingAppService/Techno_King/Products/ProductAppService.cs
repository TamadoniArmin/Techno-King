using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Products;
using App.Domain.Core.Techno_King.Service;
using Techno_KingService.Techno_King.Techno_GeneralService;

namespace Techno_KingAppService.Techno_King.Products
{
    public class ProductAppService : IProductAppService
    {
        #region Dependency Injection
        private readonly IProductService _productService;
        private readonly IGeneralService _generalService;
        public ProductAppService(IProductService productService, IGeneralService generalService)
        {
            _productService = productService;
            _generalService = generalService;
        }
        #endregion
        #region Create
        public async Task<bool> AddProductasync(NewProductDTOs newProductDTOs, CancellationToken cancellationToken)
        {
            if (newProductDTOs.ProfileImgFile1 is not null)
            {
                newProductDTOs.ImageURL1 = await _generalService.ProductUploadImage(
                    newProductDTOs.ProfileImgFile1,
                    "Products",
                    newProductDTOs.Name,
                    "image_1",
                    cancellationToken);
            }
            if (newProductDTOs.ProfileImgFile2 is not null)
            {
                newProductDTOs.ImageUrl2 = await _generalService.ProductUploadImage(
                    newProductDTOs.ProfileImgFile2,
                    "Products",
                    newProductDTOs.Name,
                    "image_2",
                    cancellationToken);
            }
            if (newProductDTOs.ProfileImgFile3 is not null)
            {
                newProductDTOs.ImageUrl3 = await _generalService.ProductUploadImage(
                    newProductDTOs.ProfileImgFile3,
                    "Products",
                    newProductDTOs.Name,
                    "image_3",
                    cancellationToken);
            }
            return await _productService.AddProductasync(newProductDTOs, cancellationToken);
        }
        #endregion
        #region Read
        #region Sorting
        #region Price Sorting
        public async Task<List<ProductDTOs>> GetProductsSortedByPriceAsync(bool ascending, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsSortedByPriceAsync(ascending, cancellationToken);
        }
        #endregion
        #region Rating Sorting
        public async Task<List<ProductDTOs>> GetProductsSortedByRatingAsync(bool ascending, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsSortedByRatingAsync(ascending, cancellationToken);
        }
        #endregion
        #endregion
        public async Task<List<ProductDTOs>> GetAllProductsAsync(CancellationToken cancellationToken)
        {
            return await _productService.GetAllProductsAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetbyBrandAsync(string brand, CancellationToken cancellationToken)
        {
            return await _productService.GetbyBrandAsync(brand, cancellationToken);
        }

        public async Task<ProductDTOs?> GetProductByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _productService.GetProductByIdAsync(id, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsBySubCategoryIdAsync(int subCategoryId, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsBySubCategoryIdAsync(subCategoryId, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsWithDiscountAsync(CancellationToken cancellationToken)
        {
            return await _productService.GetProductsWithDiscountAsync(cancellationToken);
        }
        public async Task<List<ProductDiscountDTO>> GetProductsWithHighDiscountAsync(CancellationToken cancellationToken)
        {
            return await _productService.GetProductsWithHighDiscountAsync(cancellationToken);
        }

        public async Task<List<ProductDiscountDTO>> GetProductsUpToDiscountAsync(int maxDiscountPercentage, CancellationToken cancellationToken)
        {
            return await _productService.GetProductsUpToDiscountAsync(maxDiscountPercentage, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetTopNMostExpensiveProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _productService.GetTopNMostExpensiveProductsAsync(n, cancellationToken);
        }

        public async Task<int> GetTotalProductCountAsync(CancellationToken cancellationToken)
        {
            return await _productService.GetTotalProductCountAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> SearchProductsByNameAsync(string name, CancellationToken cancellationToken)
        {
            return await _productService.SearchProductsByNameAsync(name, cancellationToken);
        }
        public async Task<List<ProductDTOs>> GetTopNSellingProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _productService.GetTopNSellingProductsAsync(n, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetTopNHighestRatedProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _productService.GetTopNHighestRatedProductsAsync(n, cancellationToken);
        }
        #endregion
        #region Update
        public async Task<bool> UpdateProductAsync(ProductDTOs productDTOs, CancellationToken cancellationToken)
        {
            return await _productService.UpdateProductAsync(productDTOs, cancellationToken);
        }

        public async Task<bool> UpdateProductDiscountAsync(int productId, int discountPercentage, CancellationToken cancellationToken)
        {
            return await _productService.UpdateProductDiscountAsync(productId, discountPercentage, cancellationToken);
        }
        #endregion
        #region Delete
        public async Task<bool> DeleteProductAsync(int id, CancellationToken cancellationToken)
        {
            return await _productService.DeleteProductAsync(id, cancellationToken);
        }
        #endregion
    }
}
