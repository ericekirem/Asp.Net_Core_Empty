using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
