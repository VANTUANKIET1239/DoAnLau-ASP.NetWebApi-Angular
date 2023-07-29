using DoAnLau_API.Data;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
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
    }
}
