using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApplicationBuffet.Views.Usuario;

namespace WebApplicationBuffet.Models.Home
{
    public class HomeService
    {
        private readonly UserManager<Usuario> _usermanager;
        private readonly SignInManager<Usuario> _signInManager;
        


        public HomeService(UserManager<Usuario> usermanager, SignInManager<Usuario> signInManager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
        }

        public async Task registrarUsuario(string email, string senha)
        {

            var novoUsuario = new Usuario()
            {
                UserName = email,
                Email = email

            };
            var resultado= await _usermanager.CreateAsync(novoUsuario, senha) ;
                
              if (!resultado.Succeeded)
              {
                  var listaErros = "";
                  foreach (var identityErro in resultado.Errors)
                  {
                      listaErros += identityErro.Description + " - ";
                  }

                  throw new Exception(listaErros);

              }
               
        } 
    }
}