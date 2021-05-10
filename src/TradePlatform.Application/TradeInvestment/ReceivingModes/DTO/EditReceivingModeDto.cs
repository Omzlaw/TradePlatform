using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes.DTO
{
    [AutoMapTo(typeof(ReceivingMode))]
    public class EditReceivingModeDto : EntityDto<int>
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