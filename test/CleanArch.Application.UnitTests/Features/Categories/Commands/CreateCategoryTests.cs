using AutoMapper;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Application.Features.Categories.Commands.CreateCategory;
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
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;


        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();

        }

        [Test]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();

            Assert.AreEqual(5, allCategories.Count);
        }
    }
}

