using ControladorAviao.Models;
using ControladorAviao.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControladorAviao.Controllers
{
    public class AviaoController : Controller
    {
        private readonly IVooRepository _vooRepository;
        private readonly IAviaoRepository _aviaoRepository;

        public AviaoController(IVooRepository vooRepository, IAviaoRepository aviaoRepository)
        {
            _vooRepository = vooRepository;
            _aviaoRepository = aviaoRepository;
        }

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
            var voos = _vooRepository;
            return View(voos);
        }
        [HttpPost]
        public IActionResult CadastrarVoo(VooModel voo)
        {
            voo = _vooRepository.Cadastrar(voo);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult CadastrarAviao(AviaoModel aviao) {
            aviao = _aviaoRepository.Cadastrar(aviao);
            return RedirectToAction("Index");
        }


    }
}
