using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes.DTO
{
    public class ReceivingModeMapProfile : Profile
    {
        public ReceivingModeMapProfile()
        {
            CreateMap<CreateReceivingModeDto, ReceivingMode>();
            CreateMap<EditReceivingModeDto, ReceivingMode>();
            CreateMap<ReceivingModeDto, ReceivingMode>();
            CreateMap<ReceivingMode, ReceivingModeListDto>();
        }
    }
}