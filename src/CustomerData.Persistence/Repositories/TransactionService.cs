using CustomerData.Application.Contracts.Infrastructure;
using CustomerData.Application.Contracts.Persistence;
using CustomerData.Application.Exceptions;
using CustomerData.Domain.Common;
using CustomerData.Domain.Entities;
using CustomerData.Domain.Enum;
using CustomerData.Domain.Services.Authentication;
using CustomerData.Domain.Services.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Persistence.Repositories
{
    public class TransactionService : ITransactionService
    {
        public Task<BaseResponse<AuthenticationResponse>> CreateTransaction(string accountId, decimal amount)
        {
            throw new NotImplementedException();
        }
    }

}
