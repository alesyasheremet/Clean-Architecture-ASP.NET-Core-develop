using CustomerData.Domain.Common;
using CustomerData.Domain.Services.Authentication;
using System.Threading.Tasks;

namespace CustomerData.Application.Contracts.Persistence
{
    public interface ITransactionService
    {
        Task<BaseResponse<AuthenticationResponse>> CreateTransaction(string accountId, decimal amount);
        
    }
}
