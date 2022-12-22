using MediatR;
using System;

namespace CustomerData.Application.Features.Events.Commands.CreateAccount
{
    public class CreateAccountCommand : IRequest<Guid>
    {
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public decimal InitialCredit { get; set; }
        public override string ToString()
        {
            return $"Create Account for userId: {UserId};";
        }
    }
}
