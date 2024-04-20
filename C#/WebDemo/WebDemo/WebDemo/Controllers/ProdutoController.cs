using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class ProdutoController : Controller
    {
        //private List<Produto> produtos;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult SaveProduto([FromForm] Produto NomeProduto)
        {
            //produtos.Add(NomeProduto);
            return RedirectToAction("Index", "Home");
        }
    }
}
