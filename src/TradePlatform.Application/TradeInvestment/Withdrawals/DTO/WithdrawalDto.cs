using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Withdrawals.DTO
{
    [AutoMap(typeof(Withdrawal))]
    public class WithdrawalDto : EntityDto<int>
    {
        public double AmountRequested { get; set; }
        public double Charges { get; set; }
        public string Status { get; set; }
        public int ReceivingModeId { get; set; }
        public int UserProfileId { get; set; }
    }
}