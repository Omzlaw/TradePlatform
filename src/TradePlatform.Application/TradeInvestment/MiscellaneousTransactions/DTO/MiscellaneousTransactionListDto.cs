using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO
{
    public class MiscellaneousTransactionListDto : EntityDto<int>
    {
        public double Amount { get; set; }
        public int PackageId { get; set; }
        public int InvestmentPlanId { get; set; }
        public int UserProfileId { get; set; }
    }
}