using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Verifications.DTO
{
    [AutoMap(typeof(Verification))]
    public class VerificationDto : EntityDto<int>
    {
        public double Amount { get; set;}
        
        public string Status { get; set;}
        
        public string PaymentMode { get; set; }
        
        public int UserProfileId { get; set; }
    }
}