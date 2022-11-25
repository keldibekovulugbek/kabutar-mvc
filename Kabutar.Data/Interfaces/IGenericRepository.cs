using Kabutar.Data.Common.Interfaces;
using Kabutar.Domain.Common;

namespace Kabutar.Data.Interfaces;

public interface IGenericRepository<T> : IRepository<T>, IReadable<T>
    where T : Auditable
{
}