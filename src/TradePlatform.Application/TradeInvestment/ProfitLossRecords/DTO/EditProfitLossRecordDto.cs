using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ProfitLossRecordss.DTO
{
    [AutoMapTo(typeof(ProfitLossRecord))]
    public class EditProfitLossRecordsDto : EntityDto<int>
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