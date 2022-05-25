using Permission.Persistence.Database.TypeRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Persistence.Database.UnitOfWork
{
    public interface IUnitOfWork
    {
        IPermisoRepository Permiso { get; }
        ITipoPermisoRepository TipoPermiso { get; }

        int Save();
    }
}
