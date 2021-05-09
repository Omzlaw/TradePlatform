using Abp.Domain.Entities;

namespace TradePlatform.Core.TradeInvestment
{
    public class Verification : Entity<int>
    {
        public bool VerificationStatus { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        
        
    }
}