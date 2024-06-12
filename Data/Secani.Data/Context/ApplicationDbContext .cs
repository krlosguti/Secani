using Microsoft.EntityFrameworkCore;
using Secani.Data.Models;

namespace Secani.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<AlertaSeguimiento> AlertasSeguimiento { get; set; }
        public DbSet<Ausencia> Ausencias { get; set; }
        public DbSet<ContactoEntidad> ContactosEntidad { get; set; }
        public DbSet<ContactoNNA> ContactosNNA { get; set; }
        public DbSet<Entidad> Entidades { get; set; }
        public DbSet<Intento> Intentos { get; set; }
        public DbSet<NNA> NNAs { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seguimiento> Seguimientos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioAsignado> UsuariosAsignados { get; set; }
        public DbSet<UsuarioRole> UsuarioRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AlertaConfiguration());
            modelBuilder.ApplyConfiguration(new AlertaSeguimientoConfiguration());
            modelBuilder.ApplyConfiguration(new AusenciaConfiguration());
            modelBuilder.ApplyConfiguration(new ContactoEntidadConfiguration());
            modelBuilder.ApplyConfiguration(new ContactoNNAConfiguration());
            modelBuilder.ApplyConfiguration(new EntidadConfiguration());
            modelBuilder.ApplyConfiguration(new IntentoConfiguration());
            modelBuilder.ApplyConfiguration(new NNAConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacionConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SeguimientoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioAsignadoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioAsignadoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioRoleConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("YourConnectionString");
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries<_BaseEntity>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    var entity = entry.Entity;
                    entity.DateCreated = DateTime.UtcNow;
                    entity.CreatedByUserId = 1;
                }

                if (entry.State == EntityState.Modified)
                {
                    var entity = entry.Entity;
                    entity.DateUpdated = DateTime.UtcNow;
                    entity.UpdatedByUserId = 2;
                }
            }

            return base.SaveChanges();
        }
    }
}
