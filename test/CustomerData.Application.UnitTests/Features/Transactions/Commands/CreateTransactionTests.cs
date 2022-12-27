using AutoMapper;
using Castle.Core.Logging;
using CustomerData.Application.Contracts.Infrastructure;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Application.Features.Transactions.Commands.CreateTransaction;
using CustomerData.Application.Profiles;
using CustomerData.Common.UnitTests.Mocks;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.UnitTests.Features.Categories.Commands
{
    public class CreateTransactionTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ITransactionRepository> _mockTransactionRepository;
        private readonly Mock<IEmailService> _mockEmailService;
        private readonly Mock<ILogger<CreateTransactionCommandHandler>> _mockLogger;


        public CreateTransactionTests()
        {
            _mockTransactionRepository = RepositoryMocks.GetTransactionRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
            _mockEmailService = new Mock<IEmailService>();
            _mockLogger = new Mock<ILogger<CreateTransactionCommandHandler>>();

        }

        [Test]
        public async Task Handle_ValidAccount_AddedToAccountRepo()
        {
            var handler = new CreateTransactionCommandHandler(_mapper, _mockTransactionRepository.Object, _mockEmailService.Object, _mockLogger.Object);

            await handler.Handle(new CreateTransactionCommand() { Date = DateTime.Now, AccountId = new Guid(), Amount = 12 }, CancellationToken.None);

            var transaction = await _mockTransactionRepository.Object.ListAllAsync();

            Assert.AreEqual(1, transaction.Count);
        }
    }
}

