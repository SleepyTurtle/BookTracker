using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTracker.Entities;

namespace BookTracker.Data
{
    public class BookTrackerContext : DbContext
    {
        public BookTrackerContext (DbContextOptions<BookTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<BookTracker.Entities.Book> Book { get; set; } = default!;
    }
}
