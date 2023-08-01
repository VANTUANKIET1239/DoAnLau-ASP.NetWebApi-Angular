using DoAnLau_API.Data;
using DoAnLau_API.FF;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnLau_API.Responsitory
{
    public class MenuResponsitory : IMenuResponsitory
    {
        private readonly DataContext _dataContext;

        public MenuResponsitory(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<bool> AddMenu(string menuCategoryId,Menu menu)
        {
            var newMenuId = _dataContext.Menus.Count();
            var menucategory = _dataContext.MenuCategories.Where(x => x.state && x.menuCategory_Id == menuCategoryId).FirstOrDefault();
            menu.menuCategory = menucategory;
            menu.menu_Id = "ME" + (newMenuId + 1).ToString("0000");
           _dataContext.Add(menu);
           return await _dataContext.SaveChangesAsync() > 0 ? true: false;
        }

        public async Task<bool> EditMenu(string menuCategoryId, Menu menu)
        {
            var menucategory = _dataContext.MenuCategories.Where(x => x.state && x.menuCategory_Id == menuCategoryId).FirstOrDefault();
            menu.menuCategory = menucategory;
            _dataContext.Update(menu);
            return await _dataContext.SaveChangesAsync() > 0 ? true : false;
        }

        public Task<int> GetAllMenusCount()
        {
            return _dataContext.Menus.CountAsync();
        }

        public async Task<Menu> GetMenu(string menuId)
        {
            var menu = await _dataContext.Menus.Where(x => x.menu_Id == menuId).FirstOrDefaultAsync();
            return menu;
            
        }

        public async Task<ICollection<Menu>> GetMenus()
        {
            var menus = await _dataContext.Menus.Where(x => x.state).ToListAsync();
            return menus;   
        }

        public async Task<ICollection<Menu>> GetMenusByMenuCategoryId(string menuCategoryId)
        {
            var menus = await _dataContext.Menus.Where(x => x.menuCategory.menuCategory_Id == menuCategoryId && x.state).ToListAsync();
            return menus;
        }

        public async Task<bool> IsMenuExists(string menuId)
        {
            bool menu  = await _dataContext.Menus.AnyAsync(x => x.menu_Id == menuId && x.state);
            return menu;
        }

        public async Task<bool> RemoveMenu(string menuId)
        {
            var menuRemove = await _dataContext.Menus.Where(x => x.state && x.menu_Id == menuId).FirstOrDefaultAsync();
            menuRemove.state = false;
            _dataContext.Update(menuRemove);
            return await _dataContext.SaveChangesAsync() > 0 ? true : false;
        }
    }
}
