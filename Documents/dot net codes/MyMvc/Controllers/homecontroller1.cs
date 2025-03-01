using Microsoft.AspNetCore.Mvc;

namespace MyMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Nits()
        {
            return View(); // This will return the Index.cshtml view
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
