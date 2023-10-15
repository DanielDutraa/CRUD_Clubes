using Microsoft.EntityFrameworkCore;

namespace CRUD_Clubes.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet <Clube> Clubes { get; set; }
    }
}
