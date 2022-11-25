using Kabutar.Domain.Entities;

namespace Kabutar.Application.ViewModels.UserViewModels;

public class UserViewModel
{
    public long Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string CreatedAt { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
   

    public static implicit operator UserViewModel(User user)
    {
        return new UserViewModel()
        {
            Id = user.Id,
            Firstname = user.FirstName,
            Lastname = user.LastName,
            Username = user.Username,
            ImagePath = user.ImagePath,
            CreatedAt = user.CreatedAt.ToString()
        };
    }
}
