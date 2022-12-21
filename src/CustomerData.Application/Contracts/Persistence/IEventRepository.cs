using CustomerData.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace CustomerData.Application.Contracts.Persistence
{
    public interface IEventRepository : IGenericRepositoryAsync<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}