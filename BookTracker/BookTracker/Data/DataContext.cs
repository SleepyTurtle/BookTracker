using Microsoft.EntityFrameworkCore;

namespace BookTracker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Entities.Book> Books { get; set; }
    }
}
