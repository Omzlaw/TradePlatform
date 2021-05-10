using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Notifications.DTO
{
    public class NotificationListDto : EntityDto<int>
    {
        public string Message { get; set; }
        public int UserProfileId { get; set; }
    }
}