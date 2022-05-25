using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permissions.Service.EventHandlers.Command
{
    public class PermisoUpdateCommand: INotification
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
    }
}
