using CustomerData.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Events.Commands.CreateEvent
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
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(e => e)
                .MustAsync(EventNameAndDateUnique)
                .WithMessage("An event with the same name and date already exists.");
        }

        private async Task<bool> EventNameAndDateUnique(CreateTransactionCommand e, CancellationToken token)
        {
            return !(await _transactionRepository.IsEventNameAndDateUnique(e.Name, e.Date));
        }
    }
}
