using Abp.Domain.Entities;

namespace TradePlatform.Core.TradeInvestment
{
    public class InvestmentPlan : Entity<int>
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