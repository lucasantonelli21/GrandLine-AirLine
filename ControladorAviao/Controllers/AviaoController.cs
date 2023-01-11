using Microsoft.AspNetCore.Mvc;

namespace ControladorAviao.Controllers
{
    public class AviaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarAviao()
        {
            return View();
        }
        public IActionResult CadastrarVoo()
        {
            return View();
        }
        public IActionResult RelatorioVoo()
        {
            return View();
        }
    }
}
