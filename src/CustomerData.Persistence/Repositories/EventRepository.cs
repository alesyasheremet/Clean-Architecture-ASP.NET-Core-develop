using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using CustomerData.Persistence.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerData.Persistence.Repositories
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
