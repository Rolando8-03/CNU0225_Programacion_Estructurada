using Microsoft.EntityFrameworkCore;

namespace UAMTest.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions option): base(option) { }
        public DbSet<Ciudad> Ciudades { get; set; }
    }
}
