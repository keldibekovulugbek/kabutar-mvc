using Kabutar.Domain.Common;

namespace Kabutar.Data.Common.Interfaces;

public interface IDeleteable<T> where T : Auditable
{
    public Task<T> DeleteAsync(long id);
}
