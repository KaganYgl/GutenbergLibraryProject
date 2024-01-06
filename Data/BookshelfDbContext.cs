using gutenberg.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace gutenberg.Data
{
    public class BookshelfDbContext : DbContext
    {
        public DbSet<BookshelfItem> BookshelfItems { get; set; }

        public BookshelfDbContext(DbContextOptions<BookshelfDbContext> options) : base(options)
        {
        }
    }

}
