using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
