using Microsoft.AspNetCore.Mvc;

namespace ProniaApplication.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
