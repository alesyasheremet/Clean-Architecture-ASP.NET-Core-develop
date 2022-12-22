using AutoMapper;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Application.Profiles;
using CustomerData.Common.UnitTests.Mocks;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.UnitTests.Features.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAccountRepository> _mockAccountRepository;

        /*
        public CreateCategoryTests()
        {
            _mockAccountRepository = RepositoryMocks.GetAccountRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();

        }

        [Test]
        public async Task Handle_ValidAccount_AddedToAccountRepo()
        {
            var handler = new CreateAccountCommandHandler(_mapper, _mockAccountRepository.Object);

            await handler.Handle(new CreateAccountCommand() {  }, CancellationToken.None);

            var allCategories = await _mockAccountRepository.Object.ListAllAsync();

            Assert.AreEqual(5, allCategories.Count);
        }
        */
    }
}

