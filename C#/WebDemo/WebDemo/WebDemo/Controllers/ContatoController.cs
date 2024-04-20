using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
    [Route("Contato")]
    public class ContatoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }

}
