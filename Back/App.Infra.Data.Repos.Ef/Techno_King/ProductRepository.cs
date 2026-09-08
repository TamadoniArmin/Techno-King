using App.Domain.Core.Techno_King.Data.Repositories;
using App.Domain.Core.Techno_King.DTOs.Products;
using Connection.Common;
using System;
using Microsoft.EntityFrameworkCore;
using App.Domain.Core.Techno_King.Entities.Catrgories;

namespace App.Infra.Data.Repos.Ef.Techno_King
{
    public class ProductRepository : IProductRepository
    {
        #region DI
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        #endregion
        #region Private Helper Methods

        private IQueryable<ProductDTOs> GetBaseProductQuery()
        {
            return _context.Products
                .AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Select(x => new ProductDTOs
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                    Brand = x.Brand,
                    DiscountPercentage = x.DiscountPercentage,
                    SubCategoryId = x.SubCategoryId,
                    AverageRating = x.AverageRating,
                    SalesCount = x.SalesCount,
                    ImageUrl1 = x.ImageUrl1,
                    ImageUrl2 = x.ImageUrl2,
                    ImageUrl3 = x.ImageUrl3,
                    IsDeleted = x.IsDeleted
                });
        }

        #endregion
        #region Create
        public async Task<bool> AddProductasync(NewProductDTOs newProductDTOs, CancellationToken cancellationToken)
        {
            var Product = new App.Domain.Core.Techno_King.Entities.Products.Product();
            Product.Name = newProductDTOs.Name;
            Product.Price = newProductDTOs.Price;
            Product.Description = newProductDTOs.Description;
            Product.Brand = newProductDTOs.Brand;
            Product.DiscountPercentage = newProductDTOs.DiscountPercentage;
            Product.SubCategoryId = newProductDTOs.SubCategoryId;
            Product.ImageUrl1 = newProductDTOs.ImageURL1;
            Product.ImageUrl2 = newProductDTOs.ImageUrl2;
            Product.ImageUrl3 = newProductDTOs.ImageUrl3;
            await _context.Products.AddAsync(Product, cancellationToken);
            var Result =await _context.SaveChangesAsync(cancellationToken);
            return Result > 0;
        }
        #endregion
        #region Read
        #region Sorting
        #region Price Sorting

        public async Task<List<ProductDTOs>> GetProductsSortedByPriceAscendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderBy(x => x.Price)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsSortedByPriceDescendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderByDescending(x => x.Price)
                .ToListAsync(cancellationToken);
        }

        #endregion
        #region Rating Sorting

        public async Task<List<ProductDTOs>> GetProductsSortedByRatingAscendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderBy(x => x.AverageRating)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsSortedByRatingDescendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderByDescending(x => x.AverageRating)
                .ToListAsync(cancellationToken);
        }

        #endregion
        #region Sales Count Sorting

        public async Task<List<ProductDTOs>> GetProductsSortedBySalesCountAscendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderBy(x => x.SalesCount)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsSortedBySalesCountDescendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderByDescending(x => x.SalesCount)
                .ToListAsync(cancellationToken);
        }

        #endregion
        #region Discount Percentage Sorting

        public async Task<List<ProductDTOs>> GetProductsSortedByDiscountPercentageAscendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderBy(x => x.DiscountPercentage)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsSortedByDiscountPercentageDescendingAsync(CancellationToken cancellationToken)
        {
            return await GetBaseProductQuery()
                .OrderByDescending(x => x.DiscountPercentage)
                .ToListAsync(cancellationToken);
        }

        #endregion
        #endregion
        public async Task<List<ProductDTOs>> GetAllProductsAsync(CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    AverageRating = p.AverageRating,
                    SalesCount = p.SalesCount,
                    ImageUrl1= p.ImageUrl1,
                    ImageUrl2= p.ImageUrl2,
                    ImageUrl3= p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetbyBrandAsync(string brand, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.Brand == brand)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }

        public async Task<ProductDTOs?> GetProductByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.Id == id)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsByCategoryIdAsync(int CategoryId, CancellationToken cancellationToken)
        {
            return await _context.Products
           .Where(p => !p.IsDeleted && p.Id == CategoryId)
           .Select(p => new ProductDTOs()
           {
               Id = p.Id,
               Name = p.Name,
               Price = p.Price,
               Description = p.Description,
               Brand = p.Brand,
               DiscountPercentage = p.DiscountPercentage,
               ImageUrl1 = p.ImageUrl1,
               ImageUrl2 = p.ImageUrl2,
               ImageUrl3 = p.ImageUrl3,
               IsDeleted = p.IsDeleted
           }).ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsBySubCategoryIdAsync(int subCategoryId, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.SubCategoryId == subCategoryId)
                .Select(p => new ProductDTOs
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    AverageRating = p.AverageRating,
                    SalesCount = p.SalesCount,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                })
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
        public async Task<List<Category>> GetSubCategoriesByParentIdAsync(int parentCategoryId, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(c => !c.IsDeleted && c.ParentId == parentCategoryId)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
        public async Task<List<ProductDiscountDTO>> GetProductsWithHighDiscountAsync(CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.DiscountPercentage > 15)
                .OrderByDescending(p => p.DiscountPercentage)
                .Select(p => new ProductDiscountDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    OriginalPrice = p.Price,
                    DiscountPercentage = p.DiscountPercentage,
                    FinalPrice = p.Price - (p.Price * p.DiscountPercentage / 100f),
                    Brand = p.Brand,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3
                })
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDiscountDTO>> GetProductsUpToDiscountAsync(int maxDiscountPercentage, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.DiscountPercentage > 0 && p.DiscountPercentage <= maxDiscountPercentage)
                .OrderByDescending(p => p.DiscountPercentage)
                .Select(p => new ProductDiscountDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    OriginalPrice = p.Price,
                    DiscountPercentage = p.DiscountPercentage,
                    FinalPrice = p.Price - (p.Price * p.DiscountPercentage / 100f),
                    Brand = p.Brand,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3
                })
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetProductsWithDiscountPercentageAsync(CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.DiscountPercentage > 0)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetTopNMostExpensiveProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted)
                .OrderByDescending(p => p.Price)
                .Take(n)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }

        public async Task<int> GetTotalProductCountAsync(CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted)
                .CountAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> SearchProductsByNameAsync(string name, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.Name.Contains(name))
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }
        public async Task<List<ProductDTOs>> GetTopNSellingProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted)
                .OrderByDescending(p => p.SalesCount)
                .Take(n)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }

        public async Task<List<ProductDTOs>> GetTopNHighestRatedProductsAsync(int n, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted)
                .OrderByDescending(p => p.AverageRating)
                .Take(n)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }
        public async Task<List<ProductDTOs>> GetProductsWithDiscountAsync(CancellationToken cancellationToken)
        {
            return await _context.Products
                .Where(p => !p.IsDeleted && p.DiscountPercentage > 0)
                .Select(p => new ProductDTOs()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Brand = p.Brand,
                    DiscountPercentage = p.DiscountPercentage,
                    SubCategoryId = p.SubCategoryId,
                    ImageUrl1 = p.ImageUrl1,
                    ImageUrl2 = p.ImageUrl2,
                    ImageUrl3 = p.ImageUrl3,
                    IsDeleted = p.IsDeleted
                }).ToListAsync(cancellationToken);
        }

        #endregion
        #region Update

        public async Task<bool> UpdateProductAsync(ProductDTOs productDTOs, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Where(p => !p.IsDeleted && p.Id == productDTOs.Id)
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
            {
                return false;
            }

            product.Name = productDTOs.Name;
            product.Price = productDTOs.Price;
            product.Description = productDTOs.Description;
            product.Brand = productDTOs.Brand;
            product.DiscountPercentage = productDTOs.DiscountPercentage;
            product.SubCategoryId = (int)productDTOs.SubCategoryId;
            product.ImageUrl1 = productDTOs.ImageUrl1;
            product.ImageUrl2 = productDTOs.ImageUrl2;
            product.ImageUrl3 = productDTOs.ImageUrl3;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }


        public async Task<bool> UpdateProductDiscountAsync(int productId, int discountPercentage, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Where(p => !p.IsDeleted && p.Id == productId)
                .FirstOrDefaultAsync(cancellationToken);
            if (product == null)
            {
                return false;
            }
            else
            {
                product.DiscountPercentage = discountPercentage;
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
        }
        #endregion
        #region Delete
        public async Task<bool> DeleteProductAsync(int id, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Where(p => !p.IsDeleted && p.Id == id)
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
            {
                return false;
            }

            product.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
        #endregion
    }
}
