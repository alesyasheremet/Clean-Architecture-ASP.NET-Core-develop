using CustomerData.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CustomerData.Persistence.Context.Seeds.Application
{
    public static class ApplicationContextSeed
    {

        public static void ApplicationSeed(this ModelBuilder modelBuilder)
        {
            CreateTransactions(modelBuilder);
            CreateAccounts(modelBuilder);
        }

        private static void CreateAccounts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(new List<Account>());
        }

        private static void CreateTransactions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().HasData(new List<Transaction>());
        }

    }
}