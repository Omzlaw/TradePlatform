using System.ComponentModel.DataAnnotations;

namespace TradePlatform.Application.TradeInvestment.Notifications.DTO
{
    public class CreateNotificationDto
    {
        [Required]
        public string Message { get; set; }
        [Required]
        public int UserProfileId { get; set; }
    }
}