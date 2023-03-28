using Microsoft.EntityFrameworkCore;

namespace CoinCatalogue.WebUI.Models.Core
{
    public class CoinCatalogueDbContext : DbContext
    {
        public DbSet<Coin> Coin { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CoinCatalogue;Trusted_Connection=True;",
                options => options.EnableRetryOnFailure(
                maxRetryCount: 10,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null
            ));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
