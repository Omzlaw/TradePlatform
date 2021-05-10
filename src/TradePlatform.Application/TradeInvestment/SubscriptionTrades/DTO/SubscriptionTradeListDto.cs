using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO
{
    public class SubscriptionTradeListDto : EntityDto<int>
    {
        public double Amount { get; set;}
        
        public string Status { get; set;}
        
        public string PaymentMode { get; set; }
        
        public int UserProfileId { get; set; }
    }
}