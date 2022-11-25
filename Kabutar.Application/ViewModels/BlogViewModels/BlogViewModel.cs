

using Kabutar.Application.ViewModels.UserViewModels;
using Kabutar.Domain.Entities;

namespace Kabutar.Application.ViewModels.BlogViewModels;

public class BlogViewModel
{
    public long Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public User Author { get; set; } = null!;
    public string Description { get; set; } = String.Empty;
    public string ImagePath { get; set; } = String.Empty;
    public string CreatedAt { get; set; } = String.Empty;

    public static implicit operator BlogViewModel(Blog blog)
    {
        return new BlogViewModel()
        {
            Id = blog.Id,
            ImagePath = blog.ImagePath,
            Description = blog.Description,
            Author = blog.Author,
            CreatedAt = blog.CreatedAt.ToString()
        };
    }
}
