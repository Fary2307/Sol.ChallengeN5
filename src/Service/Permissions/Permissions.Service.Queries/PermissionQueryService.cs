using Permission.Persistence.Database;
using Permission.Persistence.Database.UnitOfWork;
using Permissions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Permissions.Service.Queries
{

    public interface IPermissionQueryService
    {
        IEnumerable<Permiso> GetAll();
        Permiso GetBYId(int id);
    }

    public class PermissionQueryService : IPermissionQueryService
    {
        private readonly IUnitOfWork unitOfWork;
        public PermissionQueryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Permiso> GetAll()
        {
            return unitOfWork.Permiso.GetAll();
        }

        public Permiso GetBYId(int id)
        {
            return unitOfWork.Permiso.GetById(id);
        }

        public void Update(Permiso permiso)
        {
            unitOfWork.Permiso.Update(permiso);
        }
    }
}
