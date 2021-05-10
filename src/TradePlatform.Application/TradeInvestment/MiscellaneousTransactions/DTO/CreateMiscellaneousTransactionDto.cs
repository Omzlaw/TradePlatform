using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO
{
    public class CreateMiscellaneousTransactionDto
    {
        [Required]
        public double Amount { get; set; }
        [Required]
        public int PackageId { get; set; }
        [Required]
        public int InvestmentPlanId { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}