using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intergration.Models
{
    public class IntergrationDB :DbContext
    {
        private readonly IConfiguration _config;

        private readonly string _connectionString;

        public IntergrationDB(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IntergrationDB(DbContextOptions<IntergrationDB> options) : base(options)
        { }

        public IntergrationDB(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CallComment> CallComments { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.EnableSensitiveDataLogging().UseSqlServer(_config.GetConnectionString("CS"));

    }
}
