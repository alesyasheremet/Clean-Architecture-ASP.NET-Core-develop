using CustomerData.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CustomerData.Application.Contracts.Persistence
{
    public interface ITransactionRepository : IGenericRepositoryAsync<Transaction>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}