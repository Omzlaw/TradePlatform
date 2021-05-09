using Abp.Domain.Entities;

namespace TradePlatform.Core.TradeInvestment
{
    public class ReceivingMode : Entity<int>
    {
        public string Type { get; set; }
        public double MinimumAmount { get; set; }
        public double MaximumAmount { get; set; }
        public double FixedCharges { get; set; }
        public string ChargesPercentage { get; set; }
        public string Duration { get; set; }
    
    }
}