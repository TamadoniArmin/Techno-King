using App.Domain.Core.Techno_King.Data.Repositories;
using App.Domain.Core.Techno_King.DTOs.Products;
using App.Domain.Core.Techno_King.Service;

namespace Techno_KingService.Techno_King.Products
{
    public class ProductService : IProductService
    {
        #region Dependency Injection
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion
        #region Create
        public async Task<bool> AddProductasync(NewProductDTOs newProductDTOs, CancellationToken cancellationToken)
        {
            return await _productRepository.AddProductasync(newProductDTOs, cancellationToken);
        }
        #endregion
        #region Read
        #region Sorting
        #region Price Sorting
        public Task<List<ProductDTOs>> GetProductsSortedByPriceAsync(bool ascending, CancellationToken cancellationToken)
        {
            if (ascending) 
            { 
                return _productRepository.GetProductsSortedByPriceAscendingAsync(cancellationToken);
            }
            else
            {
                return _productRepository.GetProductsSortedByPriceDescendingAsync(cancellationToken);
            }
        }
        #endregion
        #region Rating Sorting
        public async Task<List<ProductDTOs>> GetProductsSortedByRatingAsync(bool ascending, CancellationToken cancellationToken)
        {
            if (ascending)
            {
                return await _productRepository.GetProductsSortedByRatingAscendingAsync(cancellationToken);
            }
            else
            {
                return await _productRepository.GetProductsSortedByRatingDescendingAsync(cancellationToken);
            }
        }
        #endregion
        #region Sales Count Sorting
        public async Task<List<ProductDTOs>> GetProductsSortedBySalesCountAsync(bool ascending, CancellationToken cancellationToken)
        {
            if (ascending)
            {
                return await _productRepository.GetProductsSortedBySalesCountAscendingAsync(cancellationToken);
            }
            else
            {
                return await _productRepository.GetProductsSortedBySalesCountDescendingAsync(cancellationToken);
            }
        }
        #endregion
        #endregion
        public async Task<List<ProductDTOs>> GetAllProductsAsync(CancellationToken cancellationToken)
        {
            return await _productRepository.GetAllProductsAsync(cancellationToken);
        }
        public async Task<List<ProductDTOs>> GetbyBrandAsync(string brand, CancellationToken cancellationToken)
        {
            return await _productRepository.GetbyBrandAsync(brand, cancellationToken);
        }
        public async Task<ProductDTOs?> GetProductByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductByIdAsync(id, cancellationToken);
        }
        public async Task<List<ProductDTOs>> GetProductsBySubCategoryIdAsync(int subCategoryId, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductsBySubCategoryIdAsync(subCategoryId, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsWithDiscountAsync(CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductsWithDiscountAsync(cancellationToken);
        }
        public async Task<List<ProductDiscountDTO>> GetProductsWithHighDiscountAsync(CancellationToken cancellationToken)
        {
            return  await _productRepository.GetProductsWithHighDiscountAsync(cancellationToken);
        }

        public async Task<List<ProductDiscountDTO>> GetProductsUpToDiscountAsync(int maxDiscountPercentage, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductsUpToDiscountAsync(maxDiscountPercentage, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetTopNMostExpensiveProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _productRepository.GetTopNMostExpensiveProductsAsync(n, cancellationToken);
        }

        public async Task<int> GetTotalProductCountAsync(CancellationToken cancellationToken)
        {
            return await _productRepository.GetTotalProductCountAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> SearchProductsByNameAsync(string name, CancellationToken cancellationToken)
        {
            return await _productRepository.SearchProductsByNameAsync(name, cancellationToken);
        }
        public async Task<List<ProductDTOs>> GetTopNSellingProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _productRepository.GetTopNSellingProductsAsync(n, cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetTopNHighestRatedProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _productRepository.GetTopNHighestRatedProductsAsync(n, cancellationToken);
        }
        #endregion
        #region Update
        public async Task<bool> UpdateProductAsync(ProductDTOs productDTOs, CancellationToken cancellationToken)
        {
            return await _productRepository.UpdateProductAsync(productDTOs, cancellationToken);
        }

        public async Task<bool> UpdateProductDiscountAsync(int productId, int discountPercentage, CancellationToken cancellationToken)
        {
            return await _productRepository.UpdateProductDiscountAsync(productId, discountPercentage, cancellationToken);
        }
        #endregion
        #region Delete
        public async Task<bool> DeleteProductAsync(int id, CancellationToken cancellationToken)
        {
            return await _productRepository.DeleteProductAsync(id, cancellationToken);
        }
        #endregion
    }
}
