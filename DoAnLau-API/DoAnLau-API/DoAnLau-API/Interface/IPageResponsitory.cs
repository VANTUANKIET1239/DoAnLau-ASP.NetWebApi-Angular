using DoAnLau_API.Models;
using DoAnLau_API.Pagination;

namespace DoAnLau_API.Interface
{
    public interface IPageResponsitory
    {
        public  Task<ICollection<T>> GetItemPage<T>(int pageindex, int pagesize, ICollection<T> pageItemCount) where T : class;
    }
}
