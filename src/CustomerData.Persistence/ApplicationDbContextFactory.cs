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
            string dbFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite($"Data Source={Path.Join(dbFolder, "customerdb.db")}");
            // Create our DbContext.
            return new ApplicationDbContext(builder.Options, null);
        }
    }
}
