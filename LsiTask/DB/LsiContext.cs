using LsiTask.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace LsiTask.DB
{
    public class LsiContext : DbContext
    {
        public LsiContext(DbContextOptions<LsiContext> options) : base(options) { }

        public DbSet<Export> Export { get; set; }
    }
}
