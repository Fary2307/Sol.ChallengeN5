using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Permissions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Persistence.Database.Configuration
{
    public class PermisoConfiguracion
    {
        public PermisoConfiguracion(EntityTypeBuilder<Permiso> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.Id);
            entityBuilder.Property(x => x.NombreEmpleado).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.ApellidoEmpleado).IsRequired().HasMaxLength(100);
        }
    }
}
