using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Deposits.DTO
{
    public class DepositMapProfile : Profile
    {
        public DepositMapProfile()
        {
            CreateMap<CreateDepositDto, Deposit>();
            CreateMap<EditDepositDto, Deposit>();
            CreateMap<DepositDto, Deposit>();
            CreateMap<Deposit, DepositListDto>();
        }
    }
}