using CustomerData.App.Mvc.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerData.App.Mvc.Controllers
{
    public class CustomerAccountsController : Controller
    {
        private readonly ICustomerAccountsService _service;

        public CustomerAccountsController(ICustomerAccountsService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> CustomerAccountsIndex()
        {
            var accounts = await _service.GetAll();
            return View(accounts);
        }
    }
}
