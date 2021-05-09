using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using TradePlatform.Authorization.Users;

namespace TradePlatform.Core.TradeInvestment
{
    public class UserProfile : Entity<int>
    {
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public long UserId {get; set;}
        public User User {get; set;}
        [NotMapped]
        public ICollection<Document> Documents { get; set; }
        public ICollection<Deposit> Deposits { get; set; }
        public ICollection<MiscellaneousTransaction> MiscellaneousTransactions { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Package> Packages { get; set; }
        public ICollection<ProfitLossRecord> ProfitLossRecords { get; set; }
        public ICollection<Referral> Referrals { get; set; }
        public ICollection<Verification> Verifications { get; set; }
        public ICollection<SubscriptionTrade> SubscriptionTrades { get; set; }
        public ICollection<Withdrawal> Withdrawals { get; set; }
        public ICollection<WithdrawalInfo> WithdrawalInfos { get; set; }
        
        
        
        
        
        
        
        
        
    }
}