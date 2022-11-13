using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebsite.Controllers
{
    public class UsesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
