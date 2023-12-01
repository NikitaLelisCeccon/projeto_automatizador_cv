using Microsoft.EntityFrameworkCore;

namespace projeto_automatizador_cv.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Curriculo> Curriculos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Experiencia> Experiencias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experiencia>()
                .HasOne(e => e.Curriculo)
                .WithMany(c => c.Experiencias)
                .HasForeignKey(e => e.CurriculoCandidato)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
