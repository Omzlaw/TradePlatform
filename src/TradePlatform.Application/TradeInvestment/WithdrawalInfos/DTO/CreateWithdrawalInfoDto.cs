using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO
{
    public class CreateWithdrawalInfoDto
    {
        [Required]
        public string BankName { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public int AccountNumber { get; set; }
        [Required]
        public string BTCAddress { get; set; } 
        [Required]
        public string ETHAddress { get; set; }
        [Required]
        public string LTCAddress { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}