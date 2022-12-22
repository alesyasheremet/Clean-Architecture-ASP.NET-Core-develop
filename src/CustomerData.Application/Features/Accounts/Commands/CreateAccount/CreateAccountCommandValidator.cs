using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Events.Commands.CreateAccount
{
    public class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public CreateAccountCommandValidator(IAccountRepository accountRepository, UserManager<ApplicationUser> userManager)
        {
            _accountRepository = accountRepository;
            _userManager = userManager;

             RuleFor(e => e)
              .MustAsync(AccountUnique)
              .WithMessage("An account for this user already exists.");

            RuleFor(e => e)
             .MustAsync(UserWithIdExists)
             .WithMessage("An account for this user already exists.");
        }
        
        private async Task<bool> AccountUnique(CreateAccountCommand e, CancellationToken token)
        {
            return !(await _accountRepository.IsAccountUnique(e.UserId));
        }

        private async Task<bool> UserWithIdExists(CreateAccountCommand e, CancellationToken token)
        {
            return await _userManager.FindByIdAsync(e.UserId) != null;
        }
    }
}
