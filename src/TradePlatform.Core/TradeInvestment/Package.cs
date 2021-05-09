using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TradePlatform.Core.TradeInvestment
{
    public class Package : Entity<int>, IFullAudited
    {
        public int InvestmentPlanId { get; set; } 
        public InvestmentPlan InvestmentPlan { get; set; }
        public DateTime ActivationDate { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public string Status { get; set; }
        public bool CurrentPackage { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}