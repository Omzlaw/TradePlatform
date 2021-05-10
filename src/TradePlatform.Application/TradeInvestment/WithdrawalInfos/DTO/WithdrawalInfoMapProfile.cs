using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO
{
    public class WithdrawalInfoMapProfile : Profile
    {
        public WithdrawalInfoMapProfile()
        {
            CreateMap<CreateWithdrawalInfoDto, WithdrawalInfo>();
            CreateMap<EditWithdrawalInfoDto, WithdrawalInfo>();
            CreateMap<WithdrawalInfoDto, WithdrawalInfo>();
            CreateMap<WithdrawalInfo, WithdrawalInfoListDto>();
        }
    }
}