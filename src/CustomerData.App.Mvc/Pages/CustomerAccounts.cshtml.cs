using CustomerData.App.Mvc.Services.Interfaces;
using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;
using CustomerData.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerData.App.Mvc.Pages
{
    public class CustomerAccountsModel : PageModel
    {
        private readonly ILogger<CustomerAccountsModel> _logger;
        private readonly ICustomerAccountsService _service;
        public IEnumerable<AccountsListVm> accounts { get; set; }

        public CustomerAccountsModel(ILogger<CustomerAccountsModel> logger, ICustomerAccountsService service)
        {
            _logger = logger;
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task OnGet()
        {

            accounts = await _service.GetAll();
        }
    }
}