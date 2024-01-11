using Agenciaapi.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenciaapi.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
              new Cliente { Id = 1, nomeCliente = "Ana", cpfCliente = "111.895.787-11", enderecoCliente = "bla bla bla", telefoneCliente = "1111", emailCliente = "01@hotmail" },
              new Cliente { Id = 2, nomeCliente = "Joana", cpfCliente = "222.895.787-11", enderecoCliente = "logo ali", telefoneCliente = "2222", emailCliente = "02@hotmail" },
              new Cliente { Id = 3, nomeCliente = "Mara", cpfCliente = "333.895.787-11", enderecoCliente = "bla bla bla", telefoneCliente = "3333", emailCliente = "03@hotmail" },
              new Cliente { Id = 4, nomeCliente = "Anderson", cpfCliente = "444.895.787-11", enderecoCliente = "logo ali", telefoneCliente = "4444", emailCliente = "04@hotmail" }
            );
        }

    }
}
