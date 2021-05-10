using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Withdrawals.DTO
{
    public class WithdrawalMapProfile : Profile
    {
        public WithdrawalMapProfile()
        {
            CreateMap<CreateWithdrawalDto, Withdrawal>();
            CreateMap<EditWithdrawalDto, Withdrawal>();
            CreateMap<WithdrawalDto, Withdrawal>();
            CreateMap<Withdrawal, WithdrawalListDto>();
        }
    }
}