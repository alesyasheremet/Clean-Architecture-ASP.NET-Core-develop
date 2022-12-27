using CustomerData.Application.Features.Transactions.Commands.CreateTransaction;
using CustomerData.Domain.Entities;
using CustomerData.Transaction.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CustomerData.Transaction.Api.Transaction.v1
{
    public class TransactionController : BaseController
    {

        private readonly string _accountApiConnectionString;
        private readonly IHttpClientFactory _clientFactory;
        public TransactionController(IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            var config = configuration.GetSection("Services");

            _accountApiConnectionString = config["AccountApi"];
            _clientFactory = clientFactory;
        }

        [HttpPost(Name = "AddTransaction")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateTransactionCommand createTransactionCommand)
        {
            var httpClient = _clientFactory.CreateClient();

            using var httpResponseMessage =
                await httpClient.GetAsync(_accountApiConnectionString + '/' + createTransactionCommand.AccountId);

            var account =
                await httpResponseMessage.Content.ReadAsAsync<Account>();

            var id = await Mediator.Send(createTransactionCommand);
            return Ok(id);
        }
    }
}