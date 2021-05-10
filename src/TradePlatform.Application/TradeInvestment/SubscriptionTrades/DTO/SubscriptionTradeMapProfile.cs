using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO
{
    public class SubscriptionTradeMapProfile : Profile
    {
        public SubscriptionTradeMapProfile()
        {
            CreateMap<CreateSubscriptionTradeDto, SubscriptionTrade>();
            CreateMap<EditSubscriptionTradeDto, SubscriptionTrade>();
            CreateMap<SubscriptionTradeDto, SubscriptionTrade>();
            CreateMap<SubscriptionTrade, SubscriptionTradeListDto>();
        }
    }
}