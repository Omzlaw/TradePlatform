using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.WithdrawalInfos.DTO
{
    [AutoMapTo(typeof(WithdrawalInfo))]
    public class EditWithdrawalInfoDto : EntityDto<int>
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