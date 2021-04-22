using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationBuffet.Models;
using WebApplicationBuffet.Models.Home;
using WebApplicationBuffet.RequestModel;
using WebApplicationBuffet.ViewModels.Home;

namespace WebApplicationBuffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }

      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
                 {
                     return View();
                 }
        public IActionResult Login()
        {
            return View();
        
        }
        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewmodel = new CadastroViewModel();
            viewmodel.Mensagem= (string) TempData["msg-Cadastro"];
            return View(viewmodel);
            
        }
        [HttpPost]
        public async Task<RedirectToActionResult> Cadastro(AcessoCadastrarRequestModels request)
        {
            
            var email= request.Email;
            var senha= request.Senha;
            var ConfirmaSenha= request.ConfirmaSenha;

            if (email == null)
            {
                TempData["msg-Cadastro"] = "Por favor, informe um email valido";
                return RedirectToAction("Cadastro");
            }
            try
            {
               await _homeService.registrarUsuario(email, senha);
                TempData["msg-Cadastro"] = "Cadastro realizado com sucesso";
                return RedirectToAction("Login");
            }
            catch(Exception exception)
            {
                TempData["msg-cadastro"] = exception.Message;
                return RedirectToAction("Cadastro");
            }
            
            
       
          
         }
        public IActionResult Recuperar()
        {
            return View();
        }
        public IActionResult Termo()
        {
            return View();
        }
        public IActionResult Politica()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}