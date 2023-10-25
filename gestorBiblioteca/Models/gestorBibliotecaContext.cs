using Microsoft.EntityFrameworkCore;

namespace gestorBiblioteca.Models
{
    public class gestorBibliotecaContext : DbContext
    {
        public DbSet<Acceso> Accesos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=gestorBibliotecaPersonal;User Id=postgres;Password=pass");
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=gestorBibliotecaPersonal;User Id=postgres;Password=pass");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura las relaciones
            modelBuilder.Entity<Usuarios>()
                .HasOne(u => u.Acceso)
                .WithMany(a => a.UsuariosConAcceso)
                .HasForeignKey(u => u.id_acceso);
        }
    }
}
