using Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Context
{
    public class CaronaPrimeContext : DbContext
    {
        public CaronaPrimeContext(DbContextOptions<CaronaPrimeContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            InactiveCascadeDelete(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CaronaPrimeContext).Assembly);
        }

        private static void InactiveCascadeDelete(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}