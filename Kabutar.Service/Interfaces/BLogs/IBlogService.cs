using Kabutar.Application.Utils;
using Kabutar.Application.ViewModels.UserViewModels;
using Kabutar.Service.Dtos.Accounts;
using Kabutar.Service.Dtos;
using Kabutar.Application.ViewModels.BlogViewModels;
using Kabutar.Service.DTOs.Blogs;

namespace Kabutar.Service.Interfaces.BLogs;

public interface IBlogService
{
    Task<bool> CreateAsync(BlogCreateDTO viewModel);
    Task<bool> UpdateAsync(long id, BlogCreateDTO viewModel);
    Task<bool> DeleteAsync(long id);
    Task<BlogViewModel> GetIdAsync(long id);
    Task<IEnumerable<BlogViewModel>> GetAllAsync(PaginationParams @params);
}
