using AutoMapper;
using CustomerData.Application.Features.Accounts.Queries.GetAccountsList;
using CustomerData.Application.Features.Events.Commands.CreateAccount;
using CustomerData.Application.Features.Transactions.Commands.CreateTransaction;
using CustomerData.Domain.Entities;

namespace CustomerData.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountsListVm>()
    .ForMember(dest =>
            dest.AccountId,
            opt => opt.MapFrom(src => src.Id))
    .ReverseMap();
            CreateMap<Transaction, CreateTransactionCommand>().ReverseMap();
            CreateMap<Account, CreateAccountCommand>().ReverseMap();
        }
    }
}