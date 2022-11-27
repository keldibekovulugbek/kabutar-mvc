using Microsoft.AspNetCore.Mvc;

namespace Kabutar.WebApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
