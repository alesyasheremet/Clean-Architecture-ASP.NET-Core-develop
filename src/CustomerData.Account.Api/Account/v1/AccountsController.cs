using CustomerData.Api.Controllers;
using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;
using CustomerData.Application.Features.Events.Commands.CreateAccount;
using CustomerData.Application.Features.Transactions.Commands.CreateTransaction;
using CustomerData.CrossCuttingConcerns.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CustomerData.Api.Account.v1
{
    public class AccountsController : BaseController
    {
        [HttpGet(Name = "GetAllAccounts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAll()
        {
            var vm = await Mediator.Send(new GetAccountsListQuery());
            return Ok(vm);
        }

        [HttpPost(Name = "AddAccount")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateAccountCommand createAccountCommand)
        {
            var id = await Mediator.Send(createAccountCommand);
         
            if (createAccountCommand.InitialCredit > 0)
            {
                await Mediator.Send(new CreateTransactionCommand() { AccountId = id, Amount = createAccountCommand.InitialCredit, Date = DateTime.Now});
            }
            return Ok(id);
        }
    }
}