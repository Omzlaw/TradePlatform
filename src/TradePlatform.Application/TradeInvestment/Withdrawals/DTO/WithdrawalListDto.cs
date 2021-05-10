using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Withdrawals.DTO
{
    public class WithdrawalListDto : EntityDto<int>
    {
        public double AmountRequested { get; set; }
        public double Charges { get; set; }
        public string Status { get; set; }
        public int ReceivingModeId { get; set; }
        public int UserProfileId { get; set; }
    }
}