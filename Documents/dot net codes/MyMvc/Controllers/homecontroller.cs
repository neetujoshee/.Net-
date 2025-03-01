using Microsoft.AspNetCore.Mvc;
using MyMvc.Models;

namespace MyMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel message = new HomeModel();
            return View(message);
        }
    }
}
