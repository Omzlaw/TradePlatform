using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO
{
    public class ProfitLossRecordsListDto : EntityDto<int>
    {
        public double Amount { get; set; }
        public string Type { get; set; }
        public int InvestmentPlanId { get; set; }
        public int UserProfileId { get; set; }
    }
}