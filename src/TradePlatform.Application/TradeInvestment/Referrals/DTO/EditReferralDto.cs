using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Referrals.DTO
{
    [AutoMapTo(typeof(Referral))]
    public class EditReferralDto : EntityDto<int>
    {
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string RefLevel { get; set; }
        [Required]
        public string Parent { get; set; }
        [Required]
        public string ClientStatus { get; set; }
        [Required]
        public DateTime DateRegistered { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}