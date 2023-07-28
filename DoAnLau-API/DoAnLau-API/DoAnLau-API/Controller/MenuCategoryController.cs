using AutoMapper;
using DoAnLau_API.Interface;
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
    }
}
