using BuffetWeb.Models.Buffet.Evento;
using BuffetWeb.ViewModels;
using BuffetWeb.ViewModels.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace BuffetWeb.Controllers.Eventos
{
    public class EventosController: Controller
    {
        private readonly EventoService _eventoService;

        public EventosController(EventoService eventoService)
        {
            _eventoService = eventoService;
        }

        public IActionResult adicionarEventos()
        {
            var viewModel = new adicionarEventosViewModels();
            return View(viewModel);
        }
        public IActionResult editarEventos()
        {
            var viewModel = new editarEventosViewModels();
            return View(viewModel);
        }
        public IActionResult eventoRemover()
        {
            var viewModel = new eventoRemoverViewModels();
            return View(viewModel);
        }
        public IActionResult listagemEventos()
        {
            var viewModel = new eventoRemoverViewModels();
            return View();
        }
    }
}