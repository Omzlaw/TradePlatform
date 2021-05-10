using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Verifications.DTO
{
    [AutoMapTo(typeof(Verification))]
    public class EditVerificationDto : EntityDto<int>
    {
        [Required]
        public bool VerificationStatus { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}