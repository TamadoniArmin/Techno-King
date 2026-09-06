using App.Domain.Core.Techno_King.App.Domain.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Techno_King_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController (ICategoryAppService categoryAppService) : ControllerBase
    {
        #region Create
        #endregion
        #region Read
        #region Category
        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories(CancellationToken cancellationToken)
        {
            var categories = await categoryAppService.GetAllCategoriesInfoAsync(cancellationToken);
            return Ok(categories);
        }
        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int categoryId, CancellationToken cancellationToken)
        {
            var category = await categoryAppService.GetCategoryInfoByIdAsync(categoryId, cancellationToken);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpGet("GetCategoryByName")]
        public async Task<IActionResult> GetCategoryByName(string categoryName, CancellationToken cancellationToken)
        {
            var category = await categoryAppService.GetCategoryInfoByNameAsync(categoryName, cancellationToken);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpGet("SearchCategoryByName")]
        public async Task<IActionResult> SearchCategoryByName(string categoryName, CancellationToken cancellationToken)
        {
            var categories = await categoryAppService.SearchCategoryInfoByNameAsync(categoryName, cancellationToken);
            if (categories.IsNullOrEmpty())
            {
                return NotFound();
            }
            return Ok(categories);
        }
        #endregion
        #region Subcategory
        [HttpGet("GetAllSubcategories")]
        public async Task<IActionResult> GetAllSubcategories(CancellationToken cancellationToken)
        {
            var subcategories = await categoryAppService.GetAllSubcategoriesInfoAsync(cancellationToken);
            return Ok(subcategories);
        }
        [HttpGet("GetSubcategoriesByCategoryId")]
        public async Task<IActionResult> GetSubcategoriesByCategoryId(int categoryId, CancellationToken cancellationToken)
        {
            var subcategories = await categoryAppService.GetSubcategoriesInfoByCategoryIdAsync(categoryId, cancellationToken);
            if (subcategories.IsNullOrEmpty())
            {
                return NotFound();
            }
            return Ok(subcategories);
        }
        [HttpGet("GetSubcategoryById")]
        public async Task<IActionResult> GetSubcategoryById(int subcategoryId, CancellationToken cancellationToken)
        {
            var subcategory = await categoryAppService.GetSubcategoryInfoByIdAsync(subcategoryId, cancellationToken);
            if (subcategory == null)
            {
                return NotFound();
            }
            return Ok(subcategory);
        }
        [HttpGet("GetSubcategoryByName")]
        public async Task<IActionResult> GetSubcategoryByName(string subcategoryName, CancellationToken cancellationToken)
        {
            var subcategory = await categoryAppService.GetSubcategoryInfoByNameAsync(subcategoryName, cancellationToken);
            if (subcategory == null)
            {
                return NotFound();
            }
            return Ok(subcategory);
        }
        [HttpGet("SearchSubcategoryByName")]
        public async Task<IActionResult> SearchSubcategoryByName(string subcategoryName, CancellationToken cancellationToken)
        {
            var subcategories = await categoryAppService.SearchSubcategoryInfoByNameAsync(subcategoryName, cancellationToken);
            if (subcategories.IsNullOrEmpty())
            {
                return NotFound();
            }
            return Ok(subcategories);
        }
        #endregion
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
