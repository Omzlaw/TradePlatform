using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Withdrawals.DTO
{
    [AutoMapTo(typeof(Withdrawal))]
    public class EditWithdrawalDto : EntityDto<int>
    {
        [Required]
        public double AmountRequested { get; set; }
        [Required]
        public double Charges { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int ReceivingModeId { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}