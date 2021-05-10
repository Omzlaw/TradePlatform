using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.SubscriptionTrades.DTO
{
    public class CreateSubscriptionTradeDto
    {
        [Required]
        public double Amount { get; set;}
        [Required]
        public string Status { get; set;}
        [Required]
        public string PaymentMode { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}