using Microsoft.EntityFrameworkCore;
using Permission.Persistence.Database.Configuration;
using Permissions.Domain;
using System;

namespace Permission.Persistence.Database
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Permissions");
            ModelConfig(builder);
        }

        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new PermisoConfiguracion(modelBuilder.Entity<Permiso>());
            new TipoPermisoConfiguracion(modelBuilder.Entity<TipoPermiso>());
        }

    }
}
