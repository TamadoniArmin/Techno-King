using App.Domain.Core.Techno_King.App.Domain.Core;
using App.Domain.Core.Techno_King.DTOs.Categories;
using App.Domain.Core.Techno_King.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_KingAppService.Techno_King.Categories
{
    public class CategoryAppService : ICategoryAppService
    {
        #region Dependency Injection
        private readonly ICategoryService _categoryService;
        public CategoryAppService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion
        #region Create
        #endregion
        #region Read
        #region Category
        public async Task<List<CategoryDTOs>> GetAllCategoriesInfoAsync(CancellationToken cancellationToken)
        {
            return await _categoryService.GetAllCategoriesInfoAsync(cancellationToken);
        }
        public async Task<CategoryDTOs?> GetCategoryInfoByIdAsync(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoryService.GetCategoryInfoByIdAsync(categoryId, cancellationToken);
        }
        public async Task<CategoryDTOs?> GetCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken)
        {
            return await _categoryService.GetCategoryInfoByNameAsync(categoryName, cancellationToken);
        }
        public async Task<List<CategoryDTOs>> SearchCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken)
        {
            return await _categoryService.SearchCategoryInfoByNameAsync(categoryName, cancellationToken);
        }
        #endregion
        #region Subcategory
        public async Task<List<SubCategoryDTOs>> GetAllSubcategoriesInfoAsync(CancellationToken cancellationToken)
        {
            return await _categoryService.GetAllSubcategoriesInfoAsync(cancellationToken);
        }
        public async Task<List<SubCategoryDTOs>> GetSubcategoriesInfoByCategoryIdAsync(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoryService.GetSubcategoriesInfoByCategoryIdAsync(categoryId, cancellationToken);
        }

        public async Task<SubCategoryDTOs?> GetSubcategoryInfoByIdAsync(int subcategoryId, CancellationToken cancellationToken)
        {
            return await _categoryService.GetSubcategoryInfoByIdAsync(subcategoryId, cancellationToken);
        }

        public async Task<SubCategoryDTOs?> GetSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken)
        {
            return await _categoryService.GetSubcategoryInfoByNameAsync(subcategoryName, cancellationToken);
        }
        public async Task<List<SubCategoryDTOs>> SearchSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken)
        {
            return await _categoryService.SearchSubcategoryInfoByNameAsync(subcategoryName, cancellationToken);
        }
        #endregion
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
