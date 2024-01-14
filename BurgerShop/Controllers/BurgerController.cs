using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
