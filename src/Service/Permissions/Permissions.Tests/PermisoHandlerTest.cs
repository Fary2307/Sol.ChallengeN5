using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Permissions.Service.EventHandlers;
using Permissions.Tests.Config;
using System.Threading.Tasks;

namespace Permissions.Tests
{
    [TestClass]
    public class PermisoHandlerTest
    {
        private ILogger<PermisoHandler> GetIlogger
        {
            get
            {
                return new Mock<ILogger<PermisoHandler>>().Object;
            }
        }

        [TestMethod]
        public async Task UpdatePermiso()
        {

        }
    }
}
