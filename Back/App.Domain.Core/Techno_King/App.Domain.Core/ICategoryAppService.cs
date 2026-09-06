using App.Domain.Core.Techno_King.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.App.Domain.Core
{
    public interface ICategoryAppService
    {
        #region Create
        #endregion
        #region Read
        #region Category
        public Task<List<CategoryDTOs>> GetAllCategoriesInfoAsync(CancellationToken cancellationToken);
        public Task<CategoryDTOs?> GetCategoryInfoByIdAsync(int categoryId, CancellationToken cancellationToken);
        public Task<CategoryDTOs?> GetCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken);
        public Task<List<CategoryDTOs>> SearchCategoryInfoByNameAsync(string categoryName, CancellationToken cancellationToken);
        #endregion
        #region Subcategory
        public Task<List<SubCategoryDTOs>> GetAllSubcategoriesInfoAsync(CancellationToken cancellationToken);
        public Task<List<SubCategoryDTOs>> GetSubcategoriesInfoByCategoryIdAsync(int categoryId, CancellationToken cancellationToken);
        public Task<SubCategoryDTOs?> GetSubcategoryInfoByIdAsync(int subcategoryId, CancellationToken cancellationToken);
        public Task<SubCategoryDTOs?> GetSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken);
        public Task<List<SubCategoryDTOs>> SearchSubcategoryInfoByNameAsync(string subcategoryName, CancellationToken cancellationToken);
        #endregion
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
