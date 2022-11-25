using Kabutar.Application.Utils;
using Kabutar.Application.ViewModels.BlogViewModels;
using Kabutar.Data.Common;
using Kabutar.Domain.Entities;

namespace Kabutar.Data.Interfaces.Blogs
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        Task<PagedList<Blog>> SearchAsync(string text, PaginationParams @params);
        Task<PagedList<Blog>> SearchByTitleAsync(string text, PaginationParams @params);
        //Task<PagedList<BlogViewModel>> GetAllViewAsync(PaginationParams @params);
        //Task<BlogViewModel?> GetViewAsync(long id);
    }
}
