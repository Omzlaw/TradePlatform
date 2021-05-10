using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO
{
    [AutoMap(typeof(MiscellaneousTransaction))]
    public class MiscellaneousTransactionDto : EntityDto<int>
    {
        public double Amount { get; set; }
        public int PackageId { get; set; }
        public int InvestmentPlanId { get; set; }
        public int UserProfileId { get; set; }
    }
}