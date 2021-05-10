using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO
{
    public class WithdrawalInfoListDto : EntityDto<int>
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