using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Verifications.DTO
{
    public class VerificationMapProfile : Profile
    {
        public VerificationMapProfile()
        {
            CreateMap<CreateVerificationDto, Verification>();
            CreateMap<EditVerificationDto, Verification>();
            CreateMap<VerificationDto, Verification>();
            CreateMap<Verification, VerificationListDto>();
        }
    }
}