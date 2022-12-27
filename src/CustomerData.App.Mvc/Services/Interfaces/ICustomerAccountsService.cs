using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;

namespace CustomerData.App.Mvc.Services.Interfaces
{
    public interface ICustomerAccountsService
    {
        Task<IEnumerable<AccountsListVm>> GetAll();
    }
}
