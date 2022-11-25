
using Kabutar.Application.Utils;
using Kabutar.Application.ViewModels.BlogViewModels;
using Kabutar.Service.DTOs.Blogs;
using Kabutar.Service.Interfaces.BLogs;

namespace Kabutar.Service.Services.Blogs;

public class BlogService : IBlogService
{
    public Task<bool> CreateAsync(BlogCreateDTO viewModel)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BlogViewModel>> GetAllAsync(PaginationParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<BlogViewModel> GetIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(long id, BlogCreateDTO viewModel)
    {
        throw new NotImplementedException();
    }
}
