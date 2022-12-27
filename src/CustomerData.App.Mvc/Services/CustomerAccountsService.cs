using CustomerData.App.Mvc.Helpers;
using CustomerData.App.Mvc.Services.Interfaces;
using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;

namespace CustomerData.App.Mvc.Services
{
    public class CustomerAccountsService : ICustomerAccountsService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/v1.0/Accounts";

        public CustomerAccountsService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<AccountsListVm>> GetAll()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<AccountsListVm>>();
        }
    }
}
