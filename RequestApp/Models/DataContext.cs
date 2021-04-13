using Microsoft.EntityFrameworkCore;

namespace RequestApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
        public DbSet<Request> Requests { get; set; }
    }
}
