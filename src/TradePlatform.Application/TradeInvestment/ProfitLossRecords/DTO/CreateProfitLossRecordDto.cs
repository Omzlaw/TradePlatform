using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO
{
    public class CreateProfitLossRecordsDto
    {
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int InvestmentPlanId { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}