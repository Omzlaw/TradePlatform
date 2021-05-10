using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.ReceivingModes.DTO
{
    public class ReceivingModeListDto : EntityDto<int>
    {
        public string Type { get; set; }
        public double MinimumAmount { get; set; }
        public double MaximumAmount { get; set; }
        public double FixedCharges { get; set; }
        public string ChargesPercentage { get; set; }
        public string Duration { get; set; }
    }
}