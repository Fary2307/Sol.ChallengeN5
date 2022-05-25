using Microsoft.EntityFrameworkCore;
using Permission.Persistence.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permissions.Tests.Config
{
    public static class ApplicationDbContextInMemory
    {
        public static AplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<AplicationDbContext>()
                .UseInMemoryDatabase(databaseName: $"Permissions.Db")
                .Options;

            return new AplicationDbContext(options);
        }
    }
}
