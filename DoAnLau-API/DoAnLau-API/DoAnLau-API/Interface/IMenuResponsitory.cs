using DoAnLau_API.Models;

namespace DoAnLau_API.Interface
{
    public interface IMenuResponsitory
    {
        public Task<ICollection<Menu>> GetMenus();

        public Task<bool> IsMenuExists (string menuId);

        public Task<Menu> GetMenu (string menuId);

        public Task<ICollection<Menu>> GetMenusByMenuCategoryId(string menuCategoryId);


    }
}
