using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.InvestmentPlans.DTO
{
    [AutoMap(typeof(InvestmentPlan))]
    public class InvestmentPlanDto : EntityDto<int>
    {
        public string PlanName { get; set; }
        public double MinimumPossibleDeposit { get; set; }
        public double MaximumPossibleDeposit { get; set; }
        public double MinimumReturn { get; set; }
        public double MaximumReturn { get; set; }
        public double GiftBonus { get; set; }
        public string Duration { get; set; }
    }
}