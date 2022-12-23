using CustomerData.Application.Contracts.Persistence;
using CustomerData.Persistence.Context;
using CustomerData.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CustomerData.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            string dbFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            services.AddDbContext<ApplicationDbContext>(options =>

                options.UseSqlite($"Data Source={Path.Join(dbFolder, "customerdb.db")}"));

            services.AddScoped(typeof(IGenericRepositoryAsync<>), typeof(GenericRepository<>));

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            return services;
        }
    }
}
