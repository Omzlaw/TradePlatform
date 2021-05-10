using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Verifications.DTO
{
    public class VerificationListDto : EntityDto<int>
    {
        public bool VerificationStatus { get; set; }
        public int UserProfileId { get; set; }
    }
}