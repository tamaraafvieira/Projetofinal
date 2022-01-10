using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.Controllers
{
    public class ConteudosController : Controller
    {
        public IActionResult Materias()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
    }
}
