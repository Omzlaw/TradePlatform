using System;
using Abp.Domain.Entities;

namespace TradePlatform.Core.TradeInvestment
{
    public class Referral : Entity<int>
    {
        public string ClientName { get; set; }
        public string RefLevel { get; set; }
        public string Parent { get; set; }
        public string ClientStatus { get; set; }
        public DateTime DateRegistered { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}