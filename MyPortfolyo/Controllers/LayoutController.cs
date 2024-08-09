using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
