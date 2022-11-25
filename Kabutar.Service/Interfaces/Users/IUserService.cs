using Kabutar.Application.Utils;
using Kabutar.Application.ViewModels.UserViewModels;
using Kabutar.Service.Dtos;
using Kabutar.Service.Dtos.Accounts;
using Microsoft.AspNetCore.Http;

namespace Kabutar.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<bool> UpdateAsync(long id, UserUpdateDto viewModel);
        Task<bool> DeleteAsync(long id);
        Task<UserViewModel> GetIdAsync(long id);
        Task<UserViewModel> GetUsernameAsync(string username);
        Task<bool> ImageUpdateAsync(long id, ImageUploadDto dto);
        Task<IEnumerable<UserViewModel>> GetAllAsync(PaginationParams @params);
    }
}
