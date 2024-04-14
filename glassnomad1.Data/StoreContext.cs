using glassnomad1.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace glassnomad1.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
