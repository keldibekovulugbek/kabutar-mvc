
using Kabutar.Data.Common.Interfaces;
using Kabutar.Domain.Common;

namespace Kabutar.Data.Interfaces;

public interface IRepository<T> : ICreateable<T>,
    IUpdateable<T>, IFindable<T>, IDeleteable<T>
    where T : Auditable
{

}