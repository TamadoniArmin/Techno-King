using App.Domain.Core.Techno_King.DTOs.Categories;
using App.Domain.Core.Techno_King.Service;
using App.Domain.Core.Techno_King.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_KingService.Techno_King.Categories
{
    public class CategoryService : ICategoryService
    {
        #region Dependency Injection
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoryService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }
        #endregion
        #region Create
        #endregion
        #region Read
        #region Category
        public async Task<List<CategoryDTOs>> GetAllCategoriesInfoAsync(CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetAllCategoriesInfoAsync(cancellationToken);
        }
        public async Task<CategoryDTOs?> GetCategoryInfoByIdAsync(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetCategoryInfoByIdAsync(categoryId, cancellationToken);
        }
        public async Task<CategoryDTOs?> GetCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetCategoryInfoByNameAsync(categoryName, cancellationToken);
        }
        public async Task<List<CategoryDTOs>> SearchCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.SearchCategoryInfoByNameAsync(categoryName, cancellationToken);
        }
        #endregion
        #region Subcategory
        public async Task<List<SubCategoryDTOs>> GetAllSubcategoriesInfoAsync(CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetAllSubcategoriesInfoAsync(cancellationToken);
        }
        public async Task<List<SubCategoryDTOs>> GetSubcategoriesInfoByCategoryIdAsync(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetSubcategoriesInfoByCategoryIdAsync(categoryId, cancellationToken);
        }

        public async Task<SubCategoryDTOs?> GetSubcategoryInfoByIdAsync(int subcategoryId, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetSubcategoryInfoByIdAsync(subcategoryId, cancellationToken);
        }

        public async Task<SubCategoryDTOs?> GetSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.GetSubcategoryInfoByNameAsync(subcategoryName, cancellationToken);
        }
        public async Task<List<SubCategoryDTOs>> SearchSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken)
        {
            return await _categoriesRepository.SearchSubcategoryInfoByNameAsync(subcategoryName, cancellationToken);
        }
        #endregion
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
