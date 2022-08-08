using EjemploEF_net6.Models;
using Microsoft.EntityFrameworkCore;

namespace EjemploEF_net6.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Cancion> Canciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cancion>().ToTable("Canciones");

        }
    }
}
