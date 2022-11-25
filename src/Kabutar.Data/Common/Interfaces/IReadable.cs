using Kabutar.Data.Common;
using Kabutar.Domain.Common;

namespace Kabutar.Data.Common.Interfaces
{
    public interface IReadable<T> where T : Auditable
    {
        public Task<PagedList<T>> GetAllAsync(PaginationParams @params);
    }
}