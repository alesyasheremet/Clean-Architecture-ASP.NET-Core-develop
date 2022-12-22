using CustomerData.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CustomerData.Application.Contracts.Persistence
{
    public interface IAccountRepository : IGenericRepositoryAsync<Account>
    {
        Task<bool> IsAccountUnique(string userId);
    }
}