using CustomerData.Application.Contracts.Persistence;
using CustomerData.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;


namespace CustomerData.Common.UnitTests.Mocks
{

    public static class RepositoryMocks
    {
        private static IReadOnlyList<Transaction> _transactionsList { get { return _transactions.AsReadOnly(); } }

        private static List<Transaction> _transactions = new List<Transaction>(); 

        internal static void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public static Mock<ITransactionRepository> GetTransactionRepository()
        {


            var mockTransactionRepository = new Mock<ITransactionRepository>();
            mockTransactionRepository.Setup(repo => repo.ListAllAsync()).ReturnsAsync(_transactionsList);

            mockTransactionRepository.Setup(repo => repo.AddAsync(It.IsAny<Transaction>())).ReturnsAsync(
                (Transaction t) =>
                {
                    AddTransaction(t);
                    return t;
                });

            return mockTransactionRepository;
        }
    }
}
