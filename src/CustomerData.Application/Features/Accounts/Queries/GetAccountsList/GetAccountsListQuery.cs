using MediatR;
using System.Collections.Generic;

namespace CustomerData.Application.Features.Events.Queries.GetEventsList
{
    public class GetAccountsListQuery : IRequest<List<AccountsListVm>>
    {

    }
}
