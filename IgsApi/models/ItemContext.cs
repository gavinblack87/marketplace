using Microsoft.EntityFrameworkCore;

namespace IgsApi.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext()
        {

        }
        
        public ItemContext(DbContextOptions<ItemContext> options) :base(options)
        {

        }
        
        public DbSet<Item> Items {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 001,
                    Name = "Lavender Heart",
                    Price = 9.25
                },
                new Item
                {
                    Id = 002,
                    Name = "Personalised cufflinks",
                    Price = 45
                },
                new Item
                {
                    Id = 003,
                    Name = "Kids T-shirt",
                    Price = 19.95
                }
            );
        }

    }
}