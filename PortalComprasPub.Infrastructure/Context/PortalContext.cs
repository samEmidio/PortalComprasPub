using Microsoft.EntityFrameworkCore;
using PortalComprasPub.Domain.Entities;

namespace PortalComprasPub.Infrastructure.Data.Context
{
    public class PortalContext : DbContext
    {
        protected override void OnConfiguring
               (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "MyDb");
        }

        public DbSet<MyEntity> Entity { get; set; }
    }
}
