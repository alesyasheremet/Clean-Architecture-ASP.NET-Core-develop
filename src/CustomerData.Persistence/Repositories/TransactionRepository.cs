using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using CustomerData.Persistence.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerData.Persistence.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> CreateAccount(string userId)
        {
            return Task.FromResult(false);
        }

    }
}
