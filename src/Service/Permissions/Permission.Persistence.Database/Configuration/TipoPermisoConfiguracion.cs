using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Permissions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Persistence.Database.Configuration
{
    public class TipoPermisoConfiguracion
    {
        public TipoPermisoConfiguracion(EntityTypeBuilder<TipoPermiso> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Descripcion).IsRequired().HasMaxLength(500);
        }
    }
}
