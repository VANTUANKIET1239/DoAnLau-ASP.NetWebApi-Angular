using DoAnLau_API.Data;
using DoAnLau_API.Interface;
using DoAnLau_API.Pagination;
using Microsoft.EntityFrameworkCore;

namespace DoAnLau_API.Responsitory
{
    public class PageResponsitory : IPageResponsitory
    {
        private readonly DataContext _dataContext;

        public PageResponsitory(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<ICollection<T>> GetItemPage<T>(int pageindex, int pagesize, ICollection<T> itemModel) where T : class 
        {
            int pageskip = (pageindex - 1) * pagesize;
            var items = await _dataContext.Set<T>().Skip(pageskip).Take(pagesize).ToListAsync();
            return items;
        }
    }
}
