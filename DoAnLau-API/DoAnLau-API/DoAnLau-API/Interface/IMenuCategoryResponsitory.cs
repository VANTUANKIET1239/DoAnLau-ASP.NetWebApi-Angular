using DoAnLau_API.Models;

namespace DoAnLau_API.Interface
{
    public interface IMenuCategoryResponsitory
    {
        public Task<ICollection<MenuCategory>> GetMenuCategories();

        public Task<MenuCategory> GetMenuCategory(string MenuCategoryId);

        public Task<bool> IsMenuCategoryExists(string MenuCategoryId);

        public Task<bool> CreateMenuCategory(MenuCategory menuCategory);

        public Task<bool> UpdateMenuCategory(MenuCategory menuCategory);

        public Task<bool> RemoveMenuCategory(MenuCategory menuCategory);
    }
}
