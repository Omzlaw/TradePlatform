using System;
using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO
{
    public class SubscriptionTradeListDto : EntityDto<int>
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
    }
}