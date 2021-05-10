using System;
using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Referrals.DTO
{
    public class ReferralListDto : EntityDto<int>
    {
        public string ClientName { get; set; }
        public string RefLevel { get; set; }
        public string Parent { get; set; }
        public string ClientStatus { get; set; }
        public DateTime DateRegistered { get; set; }
        public int UserProfileId { get; set; }
    }
}