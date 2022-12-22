using AutoMapper;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;
using CustomerData.Application.Profiles;
using CustomerData.Common.UnitTests.Mocks;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData.Application.UnitTests.Features.Categories.Queries
{
    public class GetAccountsListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAccountRepository> _mockAccountRepository;

        public GetAccountsListQueryHandlerTests()
        {
            //_mockCategoryRepository = RepositoryMocks.();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }
        /*
        [Test]
        public async Task GetCategoriesListTest()
        {
            var handler = new GetAccountsListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetAccountsListQuery(), CancellationToken.None);

            Assert.AreEqual(4, result.Count);

            Assert.That(result, Is.TypeOf<List<AccountsListVm>>());
        }
        */
    }
}
