using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.InvestmentPlans.DTO
{
    public class CreateInvestmentPlanDto
    {
        [Required]
        public string PlanName { get; set; }
        [Required]
        public double MinimumPossibleDeposit { get; set; }
        [Required]
        public double MaximumPossibleDeposit { get; set; }
        [Required]
        public double MinimumReturn { get; set; }
        [Required]
        public double MaximumReturn { get; set; }
        [Required]
        public double GiftBonus { get; set; }
        [Required]
        public string Duration { get; set; }
    }
}