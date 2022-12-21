using MediatR;
using System;

namespace CustomerData.Application.Features.Events.Commands.CreateEvent
{
    public class CreateTransactionCommand : IRequest<Guid>
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid AccountId { get; set; }
        public override string ToString()
        {
            return $"Transaction amount: {Amount}; On: {Date.ToShortDateString()}; Description: {Description}";
        }
    }
}
