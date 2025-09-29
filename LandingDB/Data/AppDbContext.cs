using LandingDB.Models;
using Microsoft.EntityFrameworkCore;

namespace LandingDB.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){} //CONSTRUCTOR
        public virtual DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.ToTable("Contacto");
                entity.Property(e => e.Nombre_Apellido).HasColumnName("nombre_apellido");
                entity.Property(e => e.Mensaje).HasColumnName("mensaje");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Fecha_Contacto).HasColumnName("fecha_contacto");
            });
        }

    }
}
