using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
