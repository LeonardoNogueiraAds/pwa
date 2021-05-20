using System;

namespace BuffetWeb.Models.Buffet.Convidado
{
    public class SituacaoConvidadoEntity
    {
        public int Id { get; set; }
        public Boolean Confirmado{ get; set; }
        public Boolean Cancelado{ get; set; }
        public Boolean EmDuvida{ get; set; }
        public Boolean DemaisOutros{ get; set; }
    }
}