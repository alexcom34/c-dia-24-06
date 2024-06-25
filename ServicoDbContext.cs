using Microsoft.EntityFrameworkCore;
using servico.models;

namespace servico.data
{
    public class ServicoDbContext : DbContext
    {
        public ServicoDbContext(DbContextOptions<ServicoDbContext> options) : base(options){}

        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contrato> Contratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aqui você pode adicionar configurações adicionais do modelo, se necessário
        }
    }
}
