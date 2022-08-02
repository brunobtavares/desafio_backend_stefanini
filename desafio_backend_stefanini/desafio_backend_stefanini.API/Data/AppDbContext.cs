using desafio_backend_stefanini.API.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_backend_stefanini.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasIndex(c => c.Id)
                .IsUnique();
            modelBuilder.Entity<Cidade>()
                .HasIndex(c => c.Id)
                .IsUnique();
        }
    }
}
