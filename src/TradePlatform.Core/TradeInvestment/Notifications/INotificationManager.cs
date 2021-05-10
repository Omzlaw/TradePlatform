using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Notifications
{
    public interface INotificationManager : IDomainService
    {
        Task<IEnumerable<Notification>> GetNotificationsByUserProfile(int userProfileId);
    }
}