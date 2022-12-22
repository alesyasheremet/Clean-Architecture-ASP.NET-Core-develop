using System;

namespace CustomerData.Application.Features.Accounts.Queries.GetAccountsList
{
    public class AccountsListVm
    {
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
