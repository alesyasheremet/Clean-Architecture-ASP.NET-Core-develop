using AutoMapper;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Events.Queries.GetEventsList
{
    public class GetAccountsListQueryHandler : IRequestHandler<GetAccountsListQuery, List<AccountsListVm>>
    {
        private readonly IGenericRepositoryAsync<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetAccountsListQueryHandler(IMapper mapper, IGenericRepositoryAsync<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<List<AccountsListVm>> Handle(GetAccountsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<AccountsListVm>>(allEvents);
        }
    }
}
