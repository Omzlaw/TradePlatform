using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Referrals.DTO
{
    [AutoMap(typeof(Referral))]
    public class ReferralDto : EntityDto<int>
    {
        public string ClientName { get; set; }
        public string RefLevel { get; set; }
        public string Parent { get; set; }
        public string ClientStatus { get; set; }
        public DateTime DateRegistered { get; set; }
        public int UserProfileId { get; set; }
    }
}