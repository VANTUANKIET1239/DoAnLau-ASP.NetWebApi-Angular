using DoAnLau_API.Data;
using DoAnLau_API.Interface;
using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAnLau_API.Responsitory
{
    public class MenuCategoryResponsitory : IMenuCategoryResponsitory
    {
        private readonly DataContext _dataContext;

        public MenuCategoryResponsitory(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<bool> CreateMenuCategory(MenuCategory menuCategory)
        {
            var getMenuCategoriesCount = _dataContext.MenuCategories.Count();
            string newMenuCategoryId = "CG" + (getMenuCategoriesCount + 1).ToString("0000");
            menuCategory.menuCategory_Id = newMenuCategoryId;
            _dataContext.MenuCategories.Add(menuCategory);
            return await _dataContext.SaveChangesAsync() > 0 ? true : false;
        }

        public async Task<ICollection<MenuCategory>> GetMenuCategories()
        {
            return await _dataContext.MenuCategories.Where(x => x.state).ToListAsync();
        }

        public async Task<MenuCategory> GetMenuCategory(string MenuCategoryId)
        {
           return await _dataContext.MenuCategories.Where(x => x.menuCategory_Id == MenuCategoryId && x.state).FirstOrDefaultAsync();
        }

        public async Task<bool> IsMenuCategoryExists(string MenuCategoryId)
        {
            return await _dataContext.MenuCategories.AnyAsync(x => x.menuCategory_Id == MenuCategoryId && x.state);
        }

        public async Task<bool> RemoveMenuCategory(MenuCategory menuCategory)
        {
            menuCategory.state = false;
            _dataContext.Update(menuCategory);
            return await _dataContext.SaveChangesAsync() > 0 ? true : false;
        }

        public async Task<bool> UpdateMenuCategory(MenuCategory menuCategory)
        {
            _dataContext.Update(menuCategory);
            return await _dataContext.SaveChangesAsync() > 0 ? true :false;
        }
    }
}
