using BuffetWeb.Models.Buffet.Locais;
using BuffetWeb.ViewModels.Locais;
using Microsoft.AspNetCore.Mvc;

namespace BuffetWeb.Controllers.Locais
{
    public class LocaisController: Controller
    {
        private readonly LocalService _localService;

        public LocaisController(LocalService localService)
        {
            _localService = localService;
        }

        public IActionResult adicionarLocais()
        {
            var viewModel = new adicionarLocaisViewModels();
            return View(viewModel);
        }
        public IActionResult editarLocais()
        {
            var viewModel = new editarLocaisViewModels();
            return View(viewModel);
        }
        public IActionResult listagemLocais()
        {
            var viewModel = new listagemLocaisViewModels();
            return View(viewModel);
        }
        public IActionResult removerLocais()
        {
            var viewModel = new removerLocaisViewModel();
            return View(viewModel);
        }
    }
}