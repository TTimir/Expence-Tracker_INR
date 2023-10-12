using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models.Domaiins
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
    }
}
