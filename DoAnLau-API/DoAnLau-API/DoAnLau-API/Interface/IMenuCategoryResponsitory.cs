using DoAnLau_API.Models;

namespace DoAnLau_API.Interface
{
    public interface IMenuCategoryResponsitory
    {
        public Task<ICollection<MenuCategory>> GetMenuCategories();

        public Task<MenuCategory> GetMenuCategory(string MenuCategoryId);

        public Task<bool> IsMenuCategoryExists(string MenuCategoryId);

       /* public Task<bool> CreateMenuCategory(MenuCategoryDTO menuCategory);

        public Task<bool> UpdateMenuCategory(MenuCategoryDTO menuCategory);

        public Task<bool> RemoveMenuCategory(string MenuCategoryId);*/
    }
}
