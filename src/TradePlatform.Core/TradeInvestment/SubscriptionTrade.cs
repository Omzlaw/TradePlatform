using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TradePlatform.Core.TradeInvestment
{
    public class SubscriptionTrade : Entity<int>, IFullAudited
    {
        public string MT4Id { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public string Leverage { get; set; }
        public string Server { get; set; }
        public string Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}