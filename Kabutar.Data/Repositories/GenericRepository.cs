
using Kabutar.Application.Utils;
using Kabutar.Data.Common;
using Kabutar.Data.Common.Interfaces;
using Kabutar.Data.DbContexts;
using Kabutar.Data.Interfaces;
using Kabutar.Domain.Common;

namespace Kabutar.Data.Repositories
{
    public class GenericRepository<T> : BaseRepository<T>,
        IGenericRepository<T> where T : Auditable
    {
        public GenericRepository(AppDbContext context) : base(context)
        {
        }

        public virtual async Task<PagedList<T>> GetAllAsync(PaginationParams @params)
        {
            return await PagedList<T>.ToPagedListAsync(_dbSet.OrderBy(x => x.Id),
                @params.PageNumber, @params.PageSize);
        }
    }
}