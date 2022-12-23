using CustomerData.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;

namespace CustomerData.Application.Features.Accounts.Queries.GetAccount
{
    public class GetAccountQuery : IRequest<Account>
    {
        public Guid AccountId { get; set; }
    }
}
