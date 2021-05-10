using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO
{
    [AutoMapTo(typeof(SubscriptionTrade))]
    public class EditSubscriptionTradeDto : EntityDto<int>
    {
        [Required]
        public string MT4Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string AccountType { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public string Leverage { get; set; }
        [Required]
        public string Server { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}