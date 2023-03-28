using Microsoft.EntityFrameworkCore;

namespace CoinCatalogue.WebUI.Models
{
    public class CoinContext : DbContext
    {
        public DbSet<Coin> Coins { get; set; }
    }
    public class Coin
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Value { get; set; }
        public int Year { get; set; }
    }
}
