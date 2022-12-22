using AutoMapper;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Accounts.Queries.GetAccountsList
{
    public class GetAccountsListQueryHandler : IRequestHandler<GetAccountsListQuery, List<AccountsListVm>>
    {
        private readonly IGenericRepositoryAsync<Account> _accountRepository;
        private readonly IMapper _mapper;

        public GetAccountsListQueryHandler(IMapper mapper, IGenericRepositoryAsync<Account> accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<List<AccountsListVm>> Handle(GetAccountsListQuery request, CancellationToken cancellationToken)
        {
            var allAccounts = (await _accountRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<AccountsListVm>>(allAccounts);
        }
    }
}
