using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Notifications.DTO
{
    [AutoMap(typeof(Notification))]
    public class NotificationDto : EntityDto<int>
    {
        public string Message { get; set; }
        public int UserProfileId { get; set; }
    }
}