using Kabutar.Data.DbContexts;
using Kabutar.Data.Interfaces;
using Kabutar.Data.Interfaces.Blogs;
using Kabutar.Data.Interfaces.Users;
using Kabutar.Data.Repositories;
using Kabutar.Data.Repositories.Blogs;
using Kabutar.Data.Repositories.Users;
using Kabutar.Service.Interfaces.BLogs;
using Kabutar.Service.Interfaces.Common;
using Kabutar.Service.Interfaces.Users;
using Kabutar.Service.Managers;
using Kabutar.Service.Security;
using Kabutar.Service.Services.Blogs;
using Kabutar.Service.Services.Common;
using Kabutar.Service.Services.Users;
using Kabutar.Services.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();


//Repositories

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddScoped<IPaginatorService, PaginatorService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IAuthManager, AuthManager>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IIdentityHelperService, IdentityHelperService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddMemoryCache();
string connectionString = builder.Configuration.GetConnectionString("ProductionDb");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
