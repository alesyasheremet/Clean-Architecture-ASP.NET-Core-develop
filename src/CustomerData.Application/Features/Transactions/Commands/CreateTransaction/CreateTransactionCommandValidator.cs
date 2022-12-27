using CustomerData.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommandValidator : AbstractValidator<CreateTransactionCommand>
    {
        private readonly ITransactionRepository _transactionRepository;
        public CreateTransactionCommandValidator(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;

            RuleFor(p => p.Amount)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0);
            
            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

        }

    }
}
