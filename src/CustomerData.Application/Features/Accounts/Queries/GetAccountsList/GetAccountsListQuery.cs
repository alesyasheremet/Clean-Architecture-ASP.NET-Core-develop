using MediatR;
using System.Collections.Generic;

namespace CustomerData.Application.Features.Accounts.Queries.GetAccountsList
{
    public class GetAccountsListQuery : IRequest<List<AccountsListVm>>
    {

    }
}
