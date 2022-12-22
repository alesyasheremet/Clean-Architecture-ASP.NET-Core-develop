using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using CustomerData.Persistence.Context;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomerData.Persistence.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsAccountUnique(string userId)
        {
            var matches = _dbContext.Accounts.Any(e => e.UserId.Equals(userId));
            return Task.FromResult(matches);
        }
    }
}
