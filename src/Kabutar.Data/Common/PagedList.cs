using Microsoft.EntityFrameworkCore;
using Kabutar.Application.Utils;

namespace Kabutar.Data.Common
{
    public class PagedList<T> : List<T>
    {
        public PaginationMetaData MetaData { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new PaginationMetaData(count, pageNumber, pageSize);
            AddRange(items);
        }
        public async static Task<PagedList<T>> ToPagedListAsync(IQueryable<T> source,
            int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip(
                (pageNumber - 1) * pageSize).Take(pageSize)
                .ToListAsync();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}