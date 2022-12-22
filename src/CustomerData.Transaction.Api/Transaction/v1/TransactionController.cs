using CustomerData.Application.Features.Transactions.Commands.CreateTransaction;
using CustomerData.Transaction.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CustomerData.Transaction.Api.Transaction.v1
{
    public class TransactionController : BaseController
    {
        [HttpPost(Name = "AddTransaction")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateTransactionCommand createTransactionCommand)
        {
            var id = await Mediator.Send(createTransactionCommand);
            return Ok(id);
        }
    }
}