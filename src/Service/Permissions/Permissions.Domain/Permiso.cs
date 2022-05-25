using System;

namespace Permissions.Domain
{
    public class Permiso
    {

        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public TipoPermiso TipoPermiso { get; set; }
        public DateTime FechaPermiso { get; set; }
    }
}
