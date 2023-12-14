namespace TiemChung.Model
{
    public class PaginateList<T> : List<T>
    {
        int PageIndex { get; set; }
        int TotalPage { get; set; }
        public PaginateList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPage = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }
        public static PaginateList<T> Create(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginateList<T>(items, count, pageIndex, pageSize);
        }
         
    }
}
