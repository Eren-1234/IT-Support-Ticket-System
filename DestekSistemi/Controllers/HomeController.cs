using Microsoft.AspNetCore.Mvc;

namespace DestekSistemi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
