using AutoMapper;
using CustomerData.Application.Contracts.Infrastructure;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using CustomerData.Domain.Services.Mail;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.Features.Transactions.Commands.CreateTransaction
{
    public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, Guid>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ILogger<CreateTransactionCommandHandler> _logger;

        public CreateTransactionCommandHandler(IMapper mapper, ITransactionRepository transactionRepository, IEmailService emailService, ILogger<CreateTransactionCommandHandler> logger)
        {
            _mapper = mapper;
            _transactionRepository = transactionRepository;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTransactionCommandValidator(_transactionRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @transaction = _mapper.Map<Transaction>(request);

            @transaction = await _transactionRepository.AddAsync(@transaction);

            // Todo: Sending email notification to admin address
            var email = new MailRequest() { ToEmail = "alesya.sheremet@gmail.com", Body = $"A new transaction was created: {request}", Subject = "A new event was created" };

            try
            {
                await _emailService.SendEmailAsync(email);
            }
            catch (Exception ex)
            {
                //this shouldn't stop the API from doing else so this can be logged
                _logger.LogError($"Mailing about event {@transaction.Id} failed due to an error with the mail service: {ex.Message}");
            }

            return @transaction.Id;
        }
    }
}