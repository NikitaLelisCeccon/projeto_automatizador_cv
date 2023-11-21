using Microsoft.EntityFrameworkCore;

namespace projeto_automatizador_cv.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Curriculo> Curriculos { get; set; }
    }
}
