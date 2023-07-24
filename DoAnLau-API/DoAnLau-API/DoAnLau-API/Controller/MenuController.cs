using DoAnLau_API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoAnLau_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuResponsitory _menuResponsitory;

        public MenuController(IMenuResponsitory menuResponsitory)
        {
            this._menuResponsitory = menuResponsitory;
        }
        [HttpGet]
        public async Task<IActionResult> GetMenus()
        {
            var menus = await _menuResponsitory.GetMenus();
            if (menus == null)
            {
                return NotFound();
            }
            return Ok(menus);

        }
        [HttpGet("{menuId}")]
        public async Task<IActionResult> GetMenu(string menuId)
        {
            if (!await _menuResponsitory.IsMenuExists(menuId))
            {
                return NotFound();
            }
            var menu = await _menuResponsitory.GetMenu(menuId);
            if (menu == null) return BadRequest();
            return Ok(menu);

        }
        [HttpGet("MenuCategory/{menuCategoryId}")]
        public async Task<IActionResult> GetMenuByMenuCategoryId(string menuCategoryId)
        {
            var menu = await _menuResponsitory.GetMenusByMenuCategoryId(menuCategoryId);
            if (menu == null) return BadRequest();
            return Ok(menu);

        }
    }
}
