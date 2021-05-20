using System;

namespace BuffetWeb.Models.Buffet.Cliente
{

 
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaMod { get; set; }
        public TipoClienteEntity TipoCliente { get; set; }
        public int Cpf { get; set; }
        public int Cnpj { get; set; }
        public DateTime DataNasimento { get; set; }

        public ClienteEntity(Guid id)
        {
            Id = new Guid();
        }

        public ClienteEntity()
        {
            throw new NotImplementedException();
        }
    }
}