
using Kabutar.Application.Utils;
using Kabutar.Application.ViewModels.BlogViewModels;
using Kabutar.Data.Common;
using Kabutar.Data.DbContexts;
using Kabutar.Data.Interfaces.Blogs;
using Kabutar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Kabutar.Data.Repositories.Blogs;

public class BlogRepository : GenericRepository<Blog>, IBlogRepository
{
    public BlogRepository(AppDbContext context) : base(context)
    {

    }

    

   
    public async Task<PagedList<Blog>> SearchAsync(string text, PaginationParams @params)
        => (await PagedList<Blog>.ToPagedListAsync(_dbSet.Where(p=> p.Title.Contains(text) || p.Description.Contains(text) ), @params.PageNumber, @params.PageSize))

    public async Task<PagedList<Blog>> SearchByTitleAsync(string text, PaginationParams @params)
        =>(await PagedList<Blog>.ToPagedListAsync(_dbSet.Where(p=> p.Title.Contains(text)), @params.PageNumber, @params.PageSize))

}
