using System;
using BuffetWeb.Models.Buffet.Evento;

namespace BuffetWeb.Models.Buffet.Convidado
{
    public class ConvidadoEntity
    {
        public string Email { get; set; }
        public EventoEntity Evento { get; set; }
        public SituacaoConvidadoEntity SituacaoConvidado { get; set; }
        public string Texto { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaMod { get; set; }
    }
}