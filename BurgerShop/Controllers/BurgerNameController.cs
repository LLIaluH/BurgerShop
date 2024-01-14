using BurgerShop.AppClases;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShop.Controllers
{
    public class BurgerNameController : Controller
    {
        private readonly BurgerShopContext _context;
        public BurgerNameController(BurgerShopContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var burgers = _context.BurgerNames.ToList();
            return View(burgers);
        }
    }
}
