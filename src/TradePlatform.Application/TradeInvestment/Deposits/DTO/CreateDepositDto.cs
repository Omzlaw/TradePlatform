using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Deposits.DTO
{
    public class CreateDepositDto
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