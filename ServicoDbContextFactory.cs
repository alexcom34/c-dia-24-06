using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace servico.data
{
    public class ServicoDbContextFactory : IDesignTimeDbContextFactory<ServicoDbContext>
    {
        public ServicoDbContext CreateDbContext(string[] args)
        {
            // Configuração da conexão com o banco de dados usando o arquivo appsettings.json
            var optionsBuilder = new DbContextOptionsBuilder<ServicoDbContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26)));

            return new ServicoDbContext(optionsBuilder.Options);
        }
    }
}
