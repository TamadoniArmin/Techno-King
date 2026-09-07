using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Techno_King.Data.Repositories;
using App.Domain.Core.Techno_King.DTOs.Categories;
using Connection.Common;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Data.Repos.Ef.Techno_King
{
    public class CategoryRepository : ICategoriesRepository
    {
        #region Dependency Injection
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        #region Create
        #endregion
        #region Read
        #region Category
        public async Task<List<CategoryDTOs>> GetAllCategoriesInfoAsync(CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && (x.ParentId == 0 || x.ParentId == null))
                .Select(x => new CategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath
                }).ToListAsync(cancellationToken);
        }
        public async Task<List<CategoryDTOs>> SearchCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.Title.Contains(categoryName) && (x.ParentId == 0 || x.ParentId == null))
                .Select(x => new CategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath
                }).ToListAsync(cancellationToken);
        }
        public async Task<CategoryDTOs?> GetCategoryInfoByIdAsync(int categoryId, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.Id == categoryId && (x.ParentId == 0 || x.ParentId == null))
                .Select(x => new CategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                }).FirstOrDefaultAsync(cancellationToken);
        }
        public async Task<CategoryDTOs?> GetCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.Title == categoryName && (x.ParentId == 0 || x.ParentId == null))
                .Select(x => new CategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                }).FirstOrDefaultAsync(cancellationToken);
        }
        #endregion
        #region Subcategory
        public async Task<List<SubCategoryDTOs>> GetAllSubcategoriesInfoAsync(CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && (x.ParentId != 0 && x.ParentId != null))
                .Select(x => new SubCategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    ParentId = x.ParentId ?? 0
                }).ToListAsync(cancellationToken);
        }
        public async Task<List<SubCategoryDTOs>> GetSubcategoriesInfoByCategoryIdAsync(int categoryId, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.ParentId == categoryId  && (x.ParentId != 0 && x.ParentId != null))
                .Select(x => new SubCategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    ParentId = x.ParentId!.Value
                }).ToListAsync(cancellationToken);
        }
        public async Task<SubCategoryDTOs?> GetSubcategoryInfoByIdAsync(int subcategoryId, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.Id == subcategoryId && (x.ParentId != 0 && x.ParentId != null))
                .Select(x => new SubCategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    ParentId = x.ParentId!.Value
                }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<SubCategoryDTOs?> GetSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.Title == subcategoryName && (x.ParentId != 0 && x.ParentId != null))
                .Select(x => new SubCategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    ParentId = x.ParentId!.Value
                }).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<SubCategoryDTOs>> SearchSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x => x.IsDeleted == false && x.Title.Contains(subcategoryName) && x.ParentId != null)
                .Select(x => new SubCategoryDTOs
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    ParentId = x.ParentId!.Value
                }).ToListAsync(cancellationToken);
        }
        #endregion
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
