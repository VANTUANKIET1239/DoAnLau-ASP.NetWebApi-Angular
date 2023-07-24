using DoAnLau_API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoAnLau_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuCategoryController : ControllerBase
    {
        private readonly IMenuCategoryResponsitory _menuCategoryResponsitory;

        public MenuCategoryController(IMenuCategoryResponsitory menuCategoryResponsitory)
        {
            this._menuCategoryResponsitory = menuCategoryResponsitory;
        }
        [HttpGet]
        public async Task<IActionResult> GetMenuCategories()
        {
            var result = await _menuCategoryResponsitory.GetMenuCategories();
            if (result == null)
            {
                return BadRequest();
            }
           return Ok(result);
        }
        [HttpGet("{menuCategoryId}")]
        public async Task<IActionResult> GetMenuCategory(string menuCategoryId)
        {
            if (!await _menuCategoryResponsitory.IsMenuCategoryExists(menuCategoryId))
            {
                return BadRequest();
            }
            var result = await _menuCategoryResponsitory.GetMenuCategory(menuCategoryId);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
