using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;

namespace CustomerData.Common.UnitTests.Mocks
{

    public static class RepositoryMocks
    {
        public static Mock<ITransactionRepository> GetTransactionRepository()
        {
            var concertGuid = Guid.NewGuid();
            var musicalGuid = Guid.NewGuid();
            var playGuid = Guid.NewGuid();
            var conferenceGuid = Guid.NewGuid();

            var transactions = new List<Transaction>
            {
                new Transaction
                {
                    Id = Guid.NewGuid(),
                    Amount = 12,
                    AccountId = Guid.NewGuid().ToString()


                },
                
            };

            var mockCategoryRepository = new Mock<ITransactionRepository>();
            mockCategoryRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(transactions);

            mockCategoryRepository.Setup(repo => repo.AddAsync(It.IsAny<Transaction>())).ReturnsAsync(
                (Transaction t) =>
                {
                    transactions.Add(t);
                    return t;
                });

            return mockCategoryRepository;
        }
    }
}
