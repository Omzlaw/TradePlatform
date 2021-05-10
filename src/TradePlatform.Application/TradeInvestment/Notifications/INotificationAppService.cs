using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TradePlatform.Application.TradeInvestment.Notifications.DTO;

namespace TradePlatform.Application.TradeInvestment.Notifications
{
    public interface INotificationAppService : IApplicationService
    {
         Task<ListResultDto<NotificationListDto>> GetNotificationsByUserProfile(int userProfileId);
    }
}