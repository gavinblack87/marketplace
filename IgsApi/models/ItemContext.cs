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
        
        public DbSet<Item> ItemItems {get; set;}

    }
}