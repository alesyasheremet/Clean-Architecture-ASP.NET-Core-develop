using AutoMapper;
using CustomerData.Application.Contracts.Infrastructure;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using CustomerData.Domain.Services.Mail;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Events.Commands.CreateAccount
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, Guid>
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<CreateAccountCommandHandler> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateAccountCommandHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IAccountRepository accountRepository, IEmailService emailService, ILogger<CreateAccountCommandHandler> logger)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
            _emailService = emailService;
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<Guid> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateAccountCommandValidator(_accountRepository, _userManager);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var user = await _userManager.FindByIdAsync(request.UserId);

            var @account = _mapper.Map<Account>(request);

            @account = await _accountRepository.AddAsync(@account);

            // Todo: Sending email notification to admin address
            var email = new MailRequest() { ToEmail = "alesya.sheremet@gmail.com", Body = $"A new account was created: {request}", Subject = "A new event was created" };

            try
            {
                await _emailService.SendEmailAsync(email);
            }
            catch (Exception ex)
            {
                //this shouldn't stop the API from doing else so this can be logged
                _logger.LogError($"Mailing about account {@account.Id} failed due to an error with the mail service: {ex.Message}");
            }

            return @account.Id;
        }
    }
}