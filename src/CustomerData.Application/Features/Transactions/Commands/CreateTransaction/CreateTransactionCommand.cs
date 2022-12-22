using MediatR;
using System;

namespace CustomerData.Application.Features.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommand : IRequest<Guid>
    {
        public DateTime Date { get; set; }
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }
        public override string ToString()
        {
            return $"Transaction for account id: {AccountId}; On: {Date.ToShortDateString()};";
        }
    }
}
