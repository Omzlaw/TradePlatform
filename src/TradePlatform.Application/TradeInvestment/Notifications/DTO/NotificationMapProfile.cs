using AutoMapper;
using TradePlatform.Core.TradeInvestment;

namespace TradePlatform.Application.TradeInvestment.Notifications.DTO
{
    public class NotificationMapProfile : Profile
    {
        public NotificationMapProfile()
        {
            CreateMap<CreateNotificationDto, Notification>();
            CreateMap<EditNotificationDto, Notification>();
            CreateMap<NotificationDto, Notification>();
            CreateMap<Notification, NotificationListDto>();
        }
    }
}