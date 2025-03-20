using EventPlus.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Context
{
    public class EventoContext : DbContext
    {
        public EventoContext()
        {

        }

        public EventoContext(DbContextOptions<EventoContext> options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<TipoEventos> TipoEventos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Presenca> PresencaEventos { get; private set; }
        public DbSet<ComentarioEventos> ComentarioEventos { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= DESKTOP-EUMC23F\\SQLEXPRESS; Database = EventPlus_API ; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
            }
        }
    }


}
