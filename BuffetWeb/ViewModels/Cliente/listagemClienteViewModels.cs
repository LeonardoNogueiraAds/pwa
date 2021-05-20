using System.Collections.Generic;

namespace BuffetWeb.ViewModels
{
    public class listagemClienteViewModels
    {
        public ICollection<Cliente> Clientes { get; set; }

        public listagemClienteViewModels()
        {
            Clientes = new List<Cliente>();
        }
    }
    
    
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Inserido { get; set; }
        public string UltimaMod { get; set; }
        public string Tipoclliente { get; set; }
        public string Cpf{ get; set; }
        public string CNPJ { get; set; }
        public string Datanascimento { get; set; }
    }
    
    
    
    
    
}

