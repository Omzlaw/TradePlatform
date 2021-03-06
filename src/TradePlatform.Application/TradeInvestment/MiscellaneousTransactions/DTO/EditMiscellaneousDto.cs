using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.MiscellaneousTransactions.DTO
{
    [AutoMapTo(typeof(MiscellaneousTransaction))]
    public class EditMiscellaneousTransactionDto : EntityDto<int>
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