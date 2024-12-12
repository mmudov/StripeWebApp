using Microsoft.EntityFrameworkCore;

namespace StripeWebApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Jacob & Co THE WORLD IS YOURS DUAL TIME ZONE", ImageUrl = "https://monochrome-watches.com/wp-content/uploads/2023/08/Jacob-and-Co-The-World-Is-Yours-Dual-Time-Zone-Watch-1.jpg", PriceID = "price_1QV644FCRscjNLWmDLp9BYMl" },
                new Item { Id = 2, Name = "Jordan T-Shirt", ImageUrl = "https://cdn.media.amplience.net/i/frasersdev/63708340_o.jpg?v=220121212030", PriceID = "price_1QV5xOFCRscjNLWm2AAOVYjj" },
                new Item { Id = 3, Name = "Summer T-Shirt", ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/5be63c100114067.5f024a0a667e0.jpg", PriceID = "price_1QV67AFCRscjNLWmGJIX1IHH" }
                );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Item> Items { get; set; }
    }
}
