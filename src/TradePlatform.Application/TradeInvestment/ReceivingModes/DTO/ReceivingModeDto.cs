using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes.DTO
{
    [AutoMap(typeof(ReceivingMode))]
    public class ReceivingModeDto : EntityDto<int>
    {
        public string Type { get; set; }
        public double MinimumAmount { get; set; }
        public double MaximumAmount { get; set; }
        public double FixedCharges { get; set; }
        public string ChargesPercentage { get; set; }
        public string Duration { get; set; }
    }
}