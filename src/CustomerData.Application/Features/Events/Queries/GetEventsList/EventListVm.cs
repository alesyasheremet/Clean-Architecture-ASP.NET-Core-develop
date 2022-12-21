using System;

namespace CustomerData.Application.Features.Events.Queries.GetEventsList
{
    public class AccountsListVm
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

    }
}
