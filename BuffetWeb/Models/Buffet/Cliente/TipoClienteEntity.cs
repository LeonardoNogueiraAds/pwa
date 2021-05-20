using System;

namespace BuffetWeb.Models.Buffet.Cliente
{
    public class TipoClienteEntity
    {
        public int id { get; set; }
        public Boolean PessoaFisica{ get; set; }    
        public Boolean PessoaJuridica{ get; set; }     
      
    }
}