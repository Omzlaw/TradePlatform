using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Withdrawals.DTO
{
    public class CreateWithdrawalDto
    {
        [Required]
        public double AmountRequested { get; set; }
        [Required]
        public double Charges { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int ReceivingModeId { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}