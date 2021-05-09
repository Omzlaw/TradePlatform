using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TradePlatform.Core.TradeInvestment
{
    public class Withdrawal : Entity<int>, IFullAudited
    {
        public double AmountRequested { get; set; }
        public double Charges { get; set; }
        public string Status { get; set; }
        public int ReceivingModeId { get; set; }
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