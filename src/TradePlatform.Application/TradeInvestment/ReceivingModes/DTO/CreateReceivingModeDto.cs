using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes.DTO
{
    public class CreateReceivingModeDto
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public double MinimumAmount { get; set; }
        [Required]
        public double MaximumAmount { get; set; }
        [Required]
        public double FixedCharges { get; set; }
        [Required]
        public string ChargesPercentage { get; set; }
        [Required]
        public string Duration { get; set; }
    }
}