using Permission.Persistence.Database.GenericRepository;
using Permission.Persistence.Database.TypeRepository.Interface;
using Permissions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Persistence.Database.TypeRepository.Implementacion
{
    class PermisoRepository : GenericRepository<Permiso>, IPermisoRepository
    {
        public PermisoRepository(AplicationDbContext context) : base(context)
        {

        }
    }
}
