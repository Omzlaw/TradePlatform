using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO
{
    [AutoMap(typeof(ProfitLossRecord))]
    public class ProfitLossRecordsDto : EntityDto<int>
    {
        public double Amount { get; set; }
        public string Type { get; set; }
        public int InvestmentPlanId { get; set; }
        public int UserProfileId { get; set; }
    }
}