using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrilldownFunctions.Data
{
    public class DrilldownDbContextFactory : IDesignTimeDbContextFactory<DrilldownDbContext>
    {
        public DrilldownDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Development.json")
                    .Build();
            var optionsBuilder = new DbContextOptionsBuilder<DrilldownDbContext>();
            optionsBuilder.UseCosmos(
                    configuration.GetConnectionString("CosmosDb"),
                    configuration.GetValue<string>("CosmosDb:DatabaseName"));

            return new DrilldownDbContext(optionsBuilder.Options);
        }
    }
}
