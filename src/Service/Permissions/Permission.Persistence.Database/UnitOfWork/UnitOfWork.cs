using Permission.Persistence.Database.TypeRepository.Implementacion;
using Permission.Persistence.Database.TypeRepository.Interface;

namespace Permission.Persistence.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AplicationDbContext context;
        public IPermisoRepository Permiso { get; private set; }
        public ITipoPermisoRepository TipoPermiso { get; private set; }


        public UnitOfWork(AplicationDbContext context)
        {
            this.context = context;
            Permiso = new PermisoRepository(this.context);
            TipoPermiso = new TipoPermisoRepository(this.context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
