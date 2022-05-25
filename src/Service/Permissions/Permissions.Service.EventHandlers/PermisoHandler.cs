using MediatR;
using Permission.Persistence.Database.UnitOfWork;
using Permissions.Service.EventHandlers.Command;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Permissions.Service.EventHandlers
{
    public class PermisoHandler : INotificationHandler<PermisoUpdateCommand>
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermisoHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task Handle(PermisoUpdateCommand command, CancellationToken cancellationToken)
        {
            _unitOfWork.Permiso.Update(new Domain.Permiso
            {
                Id = command.Id,
                ApellidoEmpleado = command.ApellidoEmpleado,
                NombreEmpleado = command.NombreEmpleado
            });

            _unitOfWork.Save();
        }
    }
}
