using Microsoft.EntityFrameworkCore;
using PortalComprasPub.Domain.Entities;

namespace AspnetCore_EFCoreInMemory.Models
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
