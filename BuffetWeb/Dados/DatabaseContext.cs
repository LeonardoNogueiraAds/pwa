using BuffetWeb.Models.Buffet.Cliente;
using BuffetWeb.Models.Buffet.Convidado;
using BuffetWeb.Models.Buffet.Evento;
using BuffetWeb.Models.Buffet.Locais;
using Microsoft.EntityFrameworkCore;

namespace BuffetWeb.Dados
{
    public class DatabaseContext : DbContext
    {
        public DbSet<LocalEntity>local { get; set; }
        public DbSet<SituacaoConvidadoEntity>situacaoconvidado { get; set; }
        public DbSet<SituacaoEventoEntity>situacaoevento { get; set; }
        public DbSet<TipoEventoEntity>tipoevento { get; set; }
        public DbSet<TipoClienteEntity>tipocliente { get; set; }
        public DbSet<ClienteEntity> cliente{ get; set; }
        public DbSet<EventoEntity> evento { get; set; }
        public DbSet<ConvidadoEntity> convidado { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}