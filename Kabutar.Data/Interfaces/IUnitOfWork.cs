using Kabutar.Data.Interfaces.Blogs;
using Kabutar.Data.Interfaces.Users;

namespace Kabutar.Data.Interfaces;

public interface IUnitOfWork
{
    public IBlogRepository Blogs{ get; }
    public IUserRepository Users { get; }
}