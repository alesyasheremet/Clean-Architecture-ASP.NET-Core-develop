using AutoMapper;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Accounts.Queries.GetAccount
{
    public class GetAccountQueryHandler : IRequestHandler<GetAccountQuery, Account>
    {
        private readonly IGenericRepositoryAsync<Account> _accountRepository;
        private readonly IMapper _mapper;

        public GetAccountQueryHandler(IMapper mapper, IGenericRepositoryAsync<Account> accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<Account> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            return await _accountRepository.GetByIdAsync(request.AccountId);
        }
    }
}
