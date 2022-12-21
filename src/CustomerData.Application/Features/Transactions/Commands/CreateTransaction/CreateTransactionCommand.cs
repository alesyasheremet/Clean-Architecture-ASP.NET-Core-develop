using MediatR;
using System;

namespace CustomerData.Application.Features.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
        public override string ToString()
        {
            return $"Transaction name: {Name}; On: {Date.ToShortDateString()}; Description: {Description}";
        }
    }
}
