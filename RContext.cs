using Microsoft.EntityFrameworkCore;

namespace Restauranter.Models
{
    public class RContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public RContext(DbContextOptions<RContext> options) : base(options) { }

        public DbSet<RReview> reviews { get; set; }
    }
}