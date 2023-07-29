namespace DoAnLau_API.Pagination
{
    public class PagedViewModel<T>
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int totalCount { get; set; }
        public int totalPages => (int)Math.Ceiling((double)totalCount / pageSize);
    }
}
