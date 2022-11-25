using Kabutar.Domain.Common;

namespace Kabutar.Data.Common.Interfaces;

public interface IFindable<T> where T : Auditable
{
    public Task<T?> FindByIdAsync(long id);
}
