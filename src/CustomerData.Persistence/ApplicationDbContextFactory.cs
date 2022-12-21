using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using CustomerData.Persistence.Context;

namespace CustomerData.Persistence
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        ApplicationDbContext IDesignTimeDbContextFactory<ApplicationDbContext>.CreateDbContext(string[] args)
        {
            //            IConfigurationRoot configuration = new ConfigurationBuilder()
            //              .SetBasePath(Directory.GetCurrentDirectory())
            //        .AddJsonFile("appsettings.json")
            //          .Build();
            // Here we create the DbContextOptionsBuilder manually.        
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Build connection string. This requires that you have a connectionstring in the appsettings.json
            //    var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(@"DataSource=./mydatabase.db;");
            // Create our DbContext.
            return new ApplicationDbContext(builder.Options, null, null);
        }
    }
}
