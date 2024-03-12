using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace GiaPhaOnline.Domain.EF
{
    public class GiaPhaDbContextFatory : IDesignTimeDbContextFactory<GiaPhaDbContext>
    {
        public GiaPhaDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("GiaPhaDb");

            var optionsBuilder = new DbContextOptionsBuilder<GiaPhaDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new GiaPhaDbContext(optionsBuilder.Options);
        }

    }
}
