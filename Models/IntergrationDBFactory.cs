using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Intergration.Models
{
    public class IntergrationDBFactory : IDesignTimeDbContextFactory<IntergrationDB>
    {
        public IntergrationDB CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            return new IntergrationDB(new DbContextOptionsBuilder<IntergrationDB>().Options, config);
        }
    }
}
