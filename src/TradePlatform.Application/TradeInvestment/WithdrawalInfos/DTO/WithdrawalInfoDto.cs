using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO
{
    [AutoMap(typeof(WithdrawalInfo))]
    public class WithdrawalInfoDto : EntityDto<int>
    {
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public int AccountNumber { get; set; }
        public string BTCAddress { get; set; } 
        public string ETHAddress { get; set; }
        public string LTCAddress { get; set; }
        public int UserProfileId { get; set; }
    }
}