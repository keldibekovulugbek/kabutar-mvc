using Kabutar.Domain.Common;

namespace Kabutar.Data.Common.Interfaces;

public interface ICreateable<T> where T : Auditable
{
    public Task<T> CreateAsync(T entity);
}
