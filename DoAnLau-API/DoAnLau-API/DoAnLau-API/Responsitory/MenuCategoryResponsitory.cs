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
    }
}
