using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO
{
    public class ProfitLossRecordsMapProfile : Profile
    {
        public ProfitLossRecordsMapProfile()
        {
            CreateMap<CreateProfitLossRecordsDto, ProfitLossRecord>();
            CreateMap<EditProfitLossRecordsDto, ProfitLossRecord>();
            CreateMap<ProfitLossRecordsDto, ProfitLossRecord>();
            CreateMap<ProfitLossRecord, ProfitLossRecordsListDto>();
        }
    }
}