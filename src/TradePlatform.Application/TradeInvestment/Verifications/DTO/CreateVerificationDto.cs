using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Verifications.DTO
{
    public class CreateVerificationDto
    {
        [Required]
        public bool VerificationStatus { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}