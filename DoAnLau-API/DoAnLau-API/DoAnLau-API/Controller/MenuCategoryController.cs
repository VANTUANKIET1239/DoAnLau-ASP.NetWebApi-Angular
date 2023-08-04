using AutoMapper;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAnLau_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuCategoryController : ControllerBase
    {
        private readonly IMenuCategoryResponsitory _menuCategoryResponsitory;
        private readonly IMapper _mapper;

        public MenuCategoryController(IMenuCategoryResponsitory menuCategoryResponsitory,IMapper mapper)
        {
            this._menuCategoryResponsitory = menuCategoryResponsitory;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetMenuCategories()
        {
            var result = await _menuCategoryResponsitory.GetMenuCategories();
            if (result == null)
            {
                return BadRequest();
            }
           return Ok(_mapper.Map<List<MenuCategoryDTO>>(result));
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
            return Ok(_mapper.Map<MenuCategoryDTO>(result));
        }
        [HttpPost("AddMenuCategory")]
        public async Task<IActionResult> AddMenuCategory(MenuCategoryDTO menuCategory)
        {
            if(menuCategory == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var menuCategoryMap = _mapper.Map<MenuCategory>(menuCategory);
            if(!await _menuCategoryResponsitory.CreateMenuCategory(menuCategoryMap))
            {
                return StatusCode(500,ModelState);
            }
            return Ok(new {success = true});
        }
        [HttpPost("EditMenuCategory")]
        public async Task<IActionResult> EditMenuCategory(MenuCategoryDTO menuCategory)
        {
            if (menuCategory == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var menuCategoryMap = _mapper.Map<MenuCategory>(menuCategory);
            if (!await _menuCategoryResponsitory.UpdateMenuCategory(menuCategoryMap))
            {
                return StatusCode(500, ModelState);
            }
            return Ok(new { success = true });
        }
        [HttpPost("RemoveMenuCategory")]
        public async Task<IActionResult> RemoveMenuCategory(MenuCategoryDTO menuCategory)
        {
            if (menuCategory.menuCategory_Id == null || menuCategory == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var menuCategoryMap = _mapper.Map<MenuCategory>(menuCategory);
            if (!await _menuCategoryResponsitory.RemoveMenuCategory(menuCategoryMap))
            {
                return StatusCode(500, ModelState);
            }
            return Ok(new { success = true });
        }
    }
}
