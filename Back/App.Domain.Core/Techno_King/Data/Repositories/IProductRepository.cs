using App.Domain.Core.Techno_King.DTOs.Products;
using App.Domain.Core.Techno_King.Entities.Catrgories;

namespace App.Domain.Core.Techno_King.Data.Repositories
{
    public interface IProductRepository
    {
        #region Create
        public Task<bool> AddProductasync(NewProductDTOs newProductDTOs, CancellationToken cancellationToken);
        #endregion
        #region Read
        public Task<List<ProductDTOs>> GetAllProductsAsync(CancellationToken cancellationToken);
        public Task<ProductDTOs?> GetProductByIdAsync(int id, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetProductsByCategoryIdAsync(int CategoryId, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetProductsBySubCategoryIdAsync(int subCategoryId, CancellationToken cancellationToken);
        public Task<List<Category>> GetSubCategoriesByParentIdAsync(int parentCategoryId, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> SearchProductsByNameAsync(string name, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetProductsWithDiscountAsync(CancellationToken cancellationToken);
        public Task<List<ProductDiscountDTO>> GetProductsWithHighDiscountAsync(CancellationToken cancellationToken);
        public Task<List<ProductDiscountDTO>> GetProductsUpToDiscountAsync(int maxDiscountPercentage, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetTopNMostExpensiveProductsAsync(int n, CancellationToken cancellationToken);
        public Task<int> GetTotalProductCountAsync(CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetbyBrandAsync(string brand, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetTopNSellingProductsAsync(int n, CancellationToken cancellationToken);
        public Task<List<ProductDTOs>> GetTopNHighestRatedProductsAsync(int n, CancellationToken cancellationToken);

        #endregion
        #region Update
        public Task<bool> UpdateProductAsync(ProductDTOs productDTOs, CancellationToken cancellationToken);
        public Task<bool> UpdateProductDiscountAsync(int productId, int discountPercentage, CancellationToken cancellationToken);
        #endregion
        #region Delete
        public Task<bool> DeleteProductAsync(int id, CancellationToken cancellationToken);
        #endregion
    }
}
