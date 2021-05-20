using System;
using BuffetWeb.Models.Buffet.Cliente;
using Microsoft.AspNetCore.Routing.Constraints;

namespace BuffetWeb.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid id { get; set; }
        public TipoEventoEntity TipoEvento { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ClienteEntity Cliente { get; set; }
        public SituacaoEventoEntity Situacao { get; set; }
        public string Endereco { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaMod { get; set; }

        public EventoEntity(Guid id)
        {
           id = new Guid();
        }
    }
}