

using Kabutar.Data.DbContexts;
using Kabutar.Data.Interfaces;
using Kabutar.Data.Interfaces.Blogs;
using Kabutar.Data.Interfaces.Users;
using Kabutar.Data.Repositories.Blogs;
using Kabutar.Data.Repositories.Users;

namespace Kabutar.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBlogRepository Blogs { get; }
        
        public IUserRepository Users { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            Blogs = new BlogRepository(appDbContext);
            
            Users = new UserRepository(appDbContext);
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}