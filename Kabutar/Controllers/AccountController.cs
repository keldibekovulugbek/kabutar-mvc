using Kabutar.Service.Dtos;
using Kabutar.Service.Interfaces.Users;
using Microsoft.AspNetCore.Mvc;

namespace Kabutar.WebApi.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            /*await _service.RegisterAsync(dto);*/
            return View();
        }
        public async Task<IActionResult> RegistrAsync(AccountCreateDto dto)
        {
                await _service.RegisterAsync(dto);
            
            return View("Login");
        }
    }
}
