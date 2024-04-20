using Agenda.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class AgendaController : Controller
    {
        private AgendaModel agenda = AgendaModel.GetInstance();
        public IActionResult Index()
        {
            List<ContatoModel> contatos = agenda.FindAll();
            return View(contatos);
        }
    }
}
