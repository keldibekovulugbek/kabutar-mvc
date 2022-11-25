
using Kabutar.Application.Exceptions;
using Kabutar.Application.Utils;
using Kabutar.Application.ViewModels.UserViewModels;
using Kabutar.Data.Interfaces;
using Kabutar.Domain.Entities;
using Kabutar.Service.Dtos;
using Kabutar.Service.Dtos.Accounts;
using Kabutar.Service.Interfaces.Common;
using Kabutar.Service.Interfaces.Users;
using System.Net;

namespace Kabutar.Service.Services.Users;
public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;
    private readonly IPaginatorService _paginatorService;

    public UserService(IUnitOfWork unitOfWork, IFileService fileService, IPaginatorService paginatorService)
    {
        _unitOfWork = unitOfWork;
        _fileService = fileService;
        _paginatorService = paginatorService;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var result = await _unitOfWork.Users.FindByIdAsync(id);

        if (result is null)
            throw new StatusCodeException(HttpStatusCode.NotFound, message: "User don't exist");

      
        var user = await _unitOfWork.Users.DeleteAsync(id);

        return user != null;
    }

    public async Task<IEnumerable<UserViewModel>> GetAllAsync(PaginationParams @params)
    {
        var users = await _unitOfWork.Users.GetAllAsync(@params);
        _paginatorService.ToPagenator(users.MetaData);

        var userViews = new List<UserViewModel>();

        foreach (var user in users)
        {
            var userView = (UserViewModel)user;

            userViews.Add(userView);
        }

        return userViews;
    }

    public async Task<UserViewModel> GetUsernameAsync(string username)
    {
        var user = await _unitOfWork.Users.GetByUsernameAsync(username.Trim());

        if (user is null)
            throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

        var userView = (UserViewModel)user;

        return userView;
    }

    public async Task<UserViewModel> GetIdAsync(long id)
    {
        var user = await _unitOfWork.Users.FindByIdAsync(id);

        if (user is null)
            throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

        var userView = (UserViewModel)user;

        return userView;
    }

    public async Task<bool> ImageUpdateAsync(long id, ImageUploadDto dto)
    {
        var user = await _unitOfWork.Users.FindByIdAsync(id);

        if (user!.ImagePath is not null)
        {
            await _fileService.DeleteImageAsync(user.ImagePath);

            user.ImagePath = await _fileService.SaveImageAsync(dto.Image);
        }
        await _unitOfWork.Users.UpdateAsync(id, user);

        return true;
    }

    public async Task<bool> UpdateAsync(long id, UserUpdateDto viewModel)
    {
        var user = await _unitOfWork.Users.FindByIdAsync(id);
        var userName = await _unitOfWork.Users.GetByUsernameAsync(viewModel.Username.Trim());
        var phoneNumber = await _unitOfWork.Users.GetByPhonNumberAsync(viewModel.PhoneNumber.Trim());

        if (user is null)
            throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

        if (userName is not null && userName.Username != user.Username)
            throw new StatusCodeException(HttpStatusCode.BadRequest, message: "This username already exist");

        if (phoneNumber is not null && phoneNumber.PhoneNumber != user.PhoneNumber)
            throw new StatusCodeException(HttpStatusCode.BadRequest, message: "This phoneNumber already exist");

        var newUser = (User)viewModel;
        newUser.Id = id;
        newUser.UpdatedAt = DateTime.UtcNow;
        newUser.ImagePath = user.ImagePath;
        newUser.PasswordHash = user.PasswordHash;
        newUser.Salt = user.Salt;
        newUser.Email = user.Email;
        newUser.EmailConfirmed = user.EmailConfirmed;
        newUser.CreatedAt = user.CreatedAt;

        await _unitOfWork.Users.UpdateAsync(id, newUser);

        return true;
    }

   
}
