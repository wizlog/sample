using Microsoft.AspNet.Mvc;

namespace Wizlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
