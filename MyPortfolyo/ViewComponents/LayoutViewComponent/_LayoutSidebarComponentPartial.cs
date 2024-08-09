using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo.ViewComponents.LayoutViewComponent
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
