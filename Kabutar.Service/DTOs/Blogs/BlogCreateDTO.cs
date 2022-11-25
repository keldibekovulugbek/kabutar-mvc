
using Kabutar.Application.ViewModels.BlogViewModels;
using Kabutar.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Kabutar.Service.DTOs.Blogs;

public class BlogCreateDTO
{
    public long Id { get; set; }
    public string Title { get; set; } = String.Empty;
    public User Author { get; set; } = null!;
    public string Description { get; set; } = String.Empty;
    public IFormFile Image { get; set; } = null!;

    public static implicit operator Blog(BlogCreateDTO blog)
    {
        return new Blog()
        {
            Id = blog.Id,
            Description = blog.Description,
            Author = blog.Author
        };
    }
}
