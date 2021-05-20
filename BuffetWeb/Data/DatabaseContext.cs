using System;
using BuffetWeb.Models.Acesso;
using BuffetWeb.Models.Buffet.Cliente;
using BuffetWeb.Models.Buffet.Evento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BuffetWeb.Data
{
    public class DatabaseContext : IdentityDbContext<Usuario, Papel, Guid>
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<EventoEntity> Eventos { get; set; }


    }
}