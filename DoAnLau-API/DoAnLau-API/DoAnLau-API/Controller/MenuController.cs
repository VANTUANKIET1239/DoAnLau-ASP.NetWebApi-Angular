﻿using AutoMapper;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAnLau_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuResponsitory _menuResponsitory;
        private readonly IMapper _mapper;
        private readonly IPageResponsitory _pageResponsitory;

        public MenuController(IMenuResponsitory menuResponsitory, IMapper mapper, IPageResponsitory pageResponsitory )
        {
            this._menuResponsitory = menuResponsitory;
            this._mapper = mapper;
            this._pageResponsitory = pageResponsitory;
        }
        [HttpGet]
        public async Task<IActionResult> GetMenus([FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 4)
        {
            var menus = await _menuResponsitory.GetMenus(); 
            if (menus == null)
            {   
                return NotFound();
            }
            return Ok(_mapper.Map<List<MenuDTO>>(menus));

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
            return Ok(_mapper.Map<MenuDTO>(menu));

        }
        [HttpGet("MenuCategory/{menuCategoryId}")]
        public async Task<IActionResult> GetMenuByMenuCategoryId(string menuCategoryId)
        {
            var menu = await _menuResponsitory.GetMenusByMenuCategoryId(menuCategoryId);
            if (menu == null) return BadRequest();
            return Ok(_mapper.Map<List<MenuDTO>>(menu));

        }
    }
}