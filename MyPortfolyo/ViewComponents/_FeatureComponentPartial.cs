using Microsoft.AspNetCore.Mvc;
using MyPortfolyo.Context;

namespace MyPortfolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext(); 
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}

