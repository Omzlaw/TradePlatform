using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Referrals.DTO
{
    public class ReferralMapProfile : Profile
    {
        public ReferralMapProfile()
        {
            CreateMap<CreateReferralDto, Referral>();
            CreateMap<EditReferralDto, Referral>();
            CreateMap<ReferralDto, Referral>();
            CreateMap<Referral, ReferralListDto>();
        }
    }
}