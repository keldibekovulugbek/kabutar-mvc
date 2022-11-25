using Kabutar.Domain.Common;

namespace Kabutar.Data.Common.Interfaces;

public interface IUpdateable<T> where T : Auditable
{
    public Task<T> UpdateAsync(long id, T entity);
}
