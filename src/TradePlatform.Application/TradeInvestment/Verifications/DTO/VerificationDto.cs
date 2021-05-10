using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Verifications.DTO
{
    [AutoMap(typeof(Verification))]
    public class VerificationDto : EntityDto<int>
    {
        public bool VerificationStatus { get; set; }
        public int UserProfileId { get; set; }
    }
}