using Microsoft.EntityFrameworkCore;
using PortalComprasPub.Domain.Entities;
using PortalComprasPub.Infrastructure.Data.Mappings;

namespace PortalComprasPub.Infrastructure.Data.Context
{
    public class PortalContext : DbContext
    {
        public PortalContext()
        {   
        }

        protected override void OnConfiguring
               (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "MyDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MyEntity> MyEntity { get; set; }
    }
}
