using Microsoft.AspNetCore.Mvc;

namespace Kabutar.WebApi.Controllers
{
    public class BLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
