using CustomerData.Api.Controllers;
using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;
using CustomerData.Application.Features.Events.Commands.CreateAccount;
using CustomerData.Application.Features.Transactions.Commands.CreateTransaction;
using CustomerData.CrossCuttingConcerns.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using CustomerData.Application.Features.Accounts.Queries.GetAccount;

namespace CustomerData.Api.Account.v1
{
    public class AccountsController : BaseController
    {

        private readonly string _transactionApiConnectionString;
        private readonly IHttpClientFactory _clientFactory;
        public AccountsController(IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            var config = configuration.GetSection("Services");

            _transactionApiConnectionString = config["TransactionApi"];
            _clientFactory = clientFactory;
        }

        [HttpGet(Name = "GetAllAccounts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetAccountsListQuery());
            return Ok(vm);
        }

        [HttpGet("{id}", Name = "GetAccountById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetById(Guid id)
        {
            var vm = await Mediator.Send(new GetAccountQuery() { AccountId = id});
            return Ok(vm);
        }

        [HttpPost(Name = "AddAccount")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateAccountCommand createAccountCommand)
        {
            var id = await Mediator.Send(createAccountCommand);
         
            if (createAccountCommand.InitialCredit > 0)
            {
                //call transaction-api
                var command = new CreateTransactionCommand() { AccountId = id, Amount = createAccountCommand.InitialCredit, Date = DateTime.Now };
                var commandJson = new StringContent(
                    JsonSerializer.Serialize(command),//, _jsonSerializerOptions),
                    Encoding.UTF8,
                    "application/json"); ;

                var httpClient = _clientFactory.CreateClient();

                using var httpResponse =
                    await httpClient.PostAsync(_transactionApiConnectionString, commandJson);

                httpResponse.EnsureSuccessStatusCode();
            }
            return Ok(id);
        }
    }
}