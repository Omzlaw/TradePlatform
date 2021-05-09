using Abp.Domain.Entities;

namespace TradePlatform.Core.TradeInvestment
{
    public class WithdrawalInfo : Entity<int>
    {
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public string BTCAddress { get; set; } 
        public string ETHAddress { get; set; }
        public string LTCAddress { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        
        
        
        
        
        
        
    }
}