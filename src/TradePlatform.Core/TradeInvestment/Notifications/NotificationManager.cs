using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TradePlatform.Core.TradeInvestment.Notifications
{
    public class NotificationManager : DomainService, INotificationManager
    {
        private readonly IRepository<Notification, int> _notificationRepository;
        public NotificationManager(IRepository<Notification, int> notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<IEnumerable<Notification>> GetNotificationsByUserProfile(int userProfileId)
        {
            return await _notificationRepository.GetAllListAsync(d => d.UserProfileId == userProfileId); 
        }
    }
}