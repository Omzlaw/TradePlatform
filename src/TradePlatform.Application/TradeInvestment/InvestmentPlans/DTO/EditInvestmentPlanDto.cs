using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.InvestmentPlans.DTO
{
    [AutoMapTo(typeof(InvestmentPlan))]
    public class EditInvestmentPlanDto : EntityDto<int>
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